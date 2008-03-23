using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long TotalGithubfarmCommand(long[] levels)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                mark = mark + (item ^ mark);
                mark = ((mark * 5) + item) % 4096;
                mark = (mark - ((long)levels.Length + mark)) % 4096;
            }
            if (mark > 46)
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark << 2) ^ (origin + (long)i);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark + (origin - origin)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
