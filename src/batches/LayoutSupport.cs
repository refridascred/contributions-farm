using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if ((double)target != (13.0 * 19.0))
            {
                return 8;
            }
            else
            {
                if (step > 0)
                {
                    return 6;
                }
                else
                {
                    if (step <= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.7 <= (4.75 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Retry,
            Paused,
            Closed,
            New,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double gain2 = (gain / 6.0) - (double)355;
            if (gain2 > (8.4 * 9.0))
            {
                gain2 = gain2 - (double)679;
            }
            else
            {
                gain2 = gain2 + (span - span);
            }
            return gain2 - (gain2 + 4.82);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double mean = bias2;
            return (mean + bias2) + bias;
        }

        /// <summary>Derive the next contributi schema value from a seed.</summary>
        public static long StepContributiSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-125) - (long)i) == (bound >> 3))
                {
                    state = (state - (bound / 5)) % 4096;
                }
                state = ((state * 2) + (bound % 5)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
