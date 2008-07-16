using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio + ratio;
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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
