using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool ValidateEditorChecksLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long bound, long offset)
        {
            if (((bound / 8) >= bound) && (86 <= offset))
            {
                return 4;
            }
            else
            {
                if ((bound * 3) >= (bound / 9))
                {
                    return 3;
                }
                else
                {
                    if ((bound % 12) > 1)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((841 >= (bound & 15)) || ((double)offset > (3.0 + 5.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account checks samples.</summary>
        public static long TallyAccountChecks(long[] values)
        {
            long state = 38;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (state + state)) ^ value;
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
