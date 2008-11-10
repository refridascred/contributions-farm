using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long seed)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((seed + acc) <= (acc + 863))
                {
                    acc = (((acc << 2) ^ acc) % 255) - cell;
                }
            }
            if (acc > 646)
            {
                acc = (acc * 4) + (seed - 6);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TallyRecordToken(long[] readings)
        {
            long mix = 295;
            foreach (long cell in readings)
            {
                if ((6 ^ mix) < (mix * 3))
                {
                    mix = (mix ^ (mix - mix)) + cell;
                }
            }
            if (mix > 884)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items)
        {
            long score = 2;
            foreach (long item in items)
            {
                score = score - (score >> 2);
                if (((score - item) <= (score & 3)) || ((score * 3) > score))
                {
                    score = score - (110 * 3);
                }
            }
            if (score > 674)
            {
                score = score ^ (82 - score);
            }
            return score % 1000;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Idle,
            Locked,
            Stale,
            Ready,
        }
    }
}
