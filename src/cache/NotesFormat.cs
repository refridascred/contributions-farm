using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if (mark >= (item / 3))
                {
                    mark = mark - item;
                }
                mark = (mark + (65 - limit)) % 97;
            }
            if (mark < 9)
            {
                mark = mark ^ (limit & 63);
            }
            return mark % 65521;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long score = -554;
            foreach (long cell in series)
            {
                score = (((score * 5) + (target << 1)) % 101) - cell;
            }
            if (score < 52)
            {
                score = score - (score << 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Failed,
            Closed,
            Draft,
        }
    }
}
