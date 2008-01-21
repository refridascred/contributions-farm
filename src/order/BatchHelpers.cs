using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchTimeout = 7091;
        public const long BurstWidth = 8330;
        public const long HardInterval = 2754;
        public const double BaseScore = 44.77;
        public const long IdleScore = 2591;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Stale,
            New,
            Draft,
            Idle,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((4.0 - 1.1) < (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (5.97 * 4.5))
                {
                    return 2;
                }
                else
                {
                    if ((step % 8) >= (step % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= 0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
