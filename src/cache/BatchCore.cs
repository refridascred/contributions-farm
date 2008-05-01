using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long origin)
        {
            if ((double)floor != (9.71 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((origin / 5) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (origin < floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(0 <= (floor + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Find the first counter metric entry that matches the target.</summary>
        public static long LocateCounterMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
