using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long limit)
        {
            if ((limit % 10) >= (bound - bound))
            {
                return 8;
            }
            else
            {
                if (!((double)limit > (3.28 + 6.85)))
                {
                    return 6;
                }
                else
                {
                    if (((42 + limit) > bound) && ((bound + 6) < (bound + limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(limit > bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
