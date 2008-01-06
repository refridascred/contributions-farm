using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count stream channel pairs that satisfy a relation.</summary>
        public static long CompareStreamChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double scale = (double)(237 >> 2);
            return ((scale - (double)549) + bias) + offset;
        }
    }
}
