using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a editor layout value against two limits.</summary>
        public static long ClassifyEditorLayout(long bound, long offset)
        {
            long span = bound + offset;
            if (!((bound + offset) == (offset - (-75))))
            {
                return 8;
            }
            else
            {
                if (75 < (bound % 5))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + span) <= (-315)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ bound) > (offset & 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
