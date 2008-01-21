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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.45 <= (double)matches) || !(90 >= matches))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
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
