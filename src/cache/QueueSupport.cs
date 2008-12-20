using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long origin)
        {
            long step = target ^ origin;
            if (3 > step)
            {
                return 2;
            }
            else
            {
                if (((double)target <= (7.0 * 1.0)) || ((double)target == (4.3 - 1.2)))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > (1.21 / 6.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)step == (double)6))
                {
                    result = (result * 5) + (result & 63);
                }
                result = (result * 5) + (step ^ (long)i);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                anchor = (anchor - seed) + cell;
                anchor = anchor ^ 4;
            }
            return anchor;
        }
    }
}
