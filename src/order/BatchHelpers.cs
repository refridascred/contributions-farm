using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long cur = offset - target;
            if (offset > (target << 2))
            {
                return 5;
            }
            else
            {
                if ((target * 4) > (cur - cur))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 1) < (cur - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset * 5) <= target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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
