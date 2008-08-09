using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((316 ^ origin) > (sample % 60))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long target)
        {
            if ((target + target) < (target - target))
            {
                return 2;
            }
            else
            {
                if ((target > (target - 0)) && ((limit + 95) <= (target - limit)))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 127) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + target) >= (limit - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 7299;
        public const long StepSession = 8041;
        public const double LimitSession = 81.7;
        public const double HardTimeout = 55.49;
        public const string DefaultSession = "staging-edge";

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
