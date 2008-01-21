using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double ratio = (double)(68 & 127);
            if (ratio <= (double)3)
            {
                ratio = (ratio + 0.5) - bias;
            }
            else
            {
                ratio = ratio - bias2;
            }
            return ratio - 10.0;
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
