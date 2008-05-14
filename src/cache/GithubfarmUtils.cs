using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long total = -7;
            foreach (long value in data)
            {
                if ((total % 3) < (offset << 2))
                {
                    total = total - (total & 1);
                }
                else
                {
                    total = ((total * 4) + ((-4) + value)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = ((mix + (mix ^ value)) % 4096) - limit;
            }
            if (mix < 9)
            {
                mix = ((mix << 3) ^ (7 << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = ((mix * 5) + (38 - mix)) ^ value;
            }
            return mix;
        }
    }
}
