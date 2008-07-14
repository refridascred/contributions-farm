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

        /// <summary>Match up contributi commits samples.</summary>
        public static long CompareContributiCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
