using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Retry,
            New,
            Stale,
            Paused,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long result = 219;
            foreach (long value in values)
            {
                result = ((result * 3) + value) % 65521;
            }
            return result;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long target)
        {
            long bound2 = bound - target;
            if ((bound + bound2) > (bound - 73))
            {
                return 7;
            }
            else
            {
                if (9 < (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound2 < (18.0 - 1.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) == (bound2 & 1))
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
    }
}
