using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next notes metrics value.</summary>
        public static double AdjustNotesMetrics(double ratio, double bias)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = (gain - (bias + 5.0)) - ratio;
            }
            return gain - (gain * 6.1);
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Stale,
        }
    }
}
