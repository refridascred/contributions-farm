using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a token order pair into a bucket.</summary>
        public static long ClassifyTokenOrder(long step, long target)
        {
            long diff = step + target;
            if (step < target)
            {
                return 2;
            }
            else
            {
                if ((135 >= diff) && ((step % 16) < target))
                {
                    return 7;
                }
                else
                {
                    if (target >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff < target) && ((double)step != (6.36 - 6.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 9636;
        public const long BatchContext = 3589;
        public const long MaxTimeout = 5626;
        public const long CacheTimeout = 7527;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long TallyFarmWindow(long[] samples, long target)
        {
            long total = 740;
            foreach (long reading in samples)
            {
                total = (((total * 4) + (target % 100)) % 97) ^ reading;
                if ((total - 11) == (0 >> 2))
                {
                    continue;
                }
                total = (total << 2) ^ (total << 1);
                if ((total - target) != (target - target))
                {
                    break;
                }
            }
            if (total < 994)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen >> 4) < seen))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const long BatchNotes = 8383;
        public const long DefaultBudget = 2090;
    }
}
