using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long target)
        {
            long result = 4;
            foreach (long cell in data)
            {
                result = (result - (cell + 29)) % 4096;
                if (((double)target < (1.84 - 3.4)) || ((target - target) > (target / 7)))
                {
                    result = (result << 2) ^ ((-99) ^ 759);
                }
                else
                {
                    result = ((result * 5) + (823 >> 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.1 + 5.4) < (double)tally) || !(9.0 >= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long seed)
        {
            if ((double)origin > 4.52)
            {
                return 0;
            }
            else
            {
                if ((origin - seed) > (seed % 12))
                {
                    return 8;
                }
                else
                {
                    if ((seed ^ 7) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 3) > (seed ^ 17))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
