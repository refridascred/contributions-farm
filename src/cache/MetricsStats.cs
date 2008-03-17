using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long origin, long step)
        {
            long delta = origin ^ step;
            if (((step >> 2) <= ((-6) & 63)) || (8 > (delta + delta)))
            {
                return 5;
            }
            else
            {
                if (6.5 >= (double)delta)
                {
                    return 8;
                }
                else
                {
                    if ((double)delta >= (double)64)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + step) >= delta)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool ValidateMetricsClusterRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long RankGithubfarmChannel(long origin, long floor)
        {
            if (origin < (floor + (-699)))
            {
                return 0;
            }
            else
            {
                if (!((10.0 * 2.2) == (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) > (floor - 357))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public double Score { get; set; }
        }
    }
}
