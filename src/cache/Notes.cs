using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((sample + sample) <= (sample >> 3)) || (sample > hits)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 239;
        public const long BaseTools = 1872;
        public const long BatchSize = 9494;

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long floor)
        {
            if ((8.95 + 1.53) != (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset < (57 - offset))
                {
                    return 8;
                }
                else
                {
                    if (601 >= (offset ^ 50))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if ((sum - cell) > (cell + sum))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }
    }
}
