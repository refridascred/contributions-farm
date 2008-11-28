using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 9387;
        public const string BurstRoute = "alpha";
        public const long StepLevel = 3858;
        public const long WindowDepth = 7251;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Rank layout metric input into a small class.</summary>
        public static long BucketLayoutMetric(long floor, long step)
        {
            long lane = floor ^ step;
            if ((lane % 3) <= floor)
            {
                return 6;
            }
            else
            {
                if (2.3 > (double)step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings)
        {
            long sum = 111;
            foreach (long cell in readings)
            {
                if ((6 >> 4) != (cell ^ sum))
                {
                    sum = ((sum * 5) + (cell + cell)) % 4096;
                }
            }
            if (sum < (-1))
            {
                sum = (sum - (sum / 8)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
