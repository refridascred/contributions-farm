using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double weight, double offset)
        {
            double mean = (double)928;
            if (mean >= (weight + 7.18))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - weight) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Active,
            Paused,
            Ready,
            Retry,
        }
    }
}
