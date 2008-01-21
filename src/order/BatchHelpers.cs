using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if (8 > (floor + 0))
                {
                    acc = acc + (acc % 7);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
