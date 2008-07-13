using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long state = 642;
            foreach (long item in levels)
            {
                if ((seed & 15) > (state ^ seed))
                {
                    state = (state + (907 + state)) + item;
                }
                else
                {
                    state = ((state * 2) + (seed % 97)) % 97;
                }
            }
            if (state > 200)
            {
                state = ((state * 5) + 304) % 4096;
            }
            return state;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double scale = (double)(9 + 921);
            return (scale + (bias - 5.0)) + floor;
        }
    }
}
