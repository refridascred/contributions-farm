using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine queue checks values into a single score.</summary>
        public static long WeighQueueChecks(long[] samples, long step)
        {
            long anchor = 81;
            foreach (long value in samples)
            {
                if ((19 > anchor) && ((step & 15) >= (-87)))
                {
                    anchor = (anchor * 4) + 0;
                }
                anchor = ((anchor * 2) + anchor) % 1000;
                if ((step & 127) <= (value - 19))
                {
                    anchor = (anchor ^ (value * 5)) % 4096;
                }
                if ((double)value != (7.0 / 6.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long target)
        {
            long offset = step + target;
            if (((7.18 - 19.0) < (double)offset) && (step >= (target + target)))
            {
                return 5;
            }
            else
            {
                if ((double)target == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 5.33) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step + target) < (449 % 12)) || ((double)offset >= (0.28 / 8.0)))
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

        /// <summary>Roll a filter token counter forward.</summary>
        public static long IterateFilterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
