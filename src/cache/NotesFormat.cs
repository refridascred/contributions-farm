using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double mean = (bias + gain) + (bias / 4.0);
            return mean + bias;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Retry,
            Locked,
            Idle,
            Paused,
        }
    }
}
