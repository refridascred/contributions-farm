using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double ratio = (double)(5 / 3);
            if (ratio >= offset)
            {
                ratio = (ratio + ratio) + weight;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Done,
            Locked,
            Ready,
            Queued,
        }
    }
}
