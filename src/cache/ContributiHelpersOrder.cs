using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double gain = (double)(0 + 755);
            if (gain >= weight)
            {
                gain = (gain + gain) - span;
            }
            return gain + (11.0 * 7.6);
        }
    }
}
