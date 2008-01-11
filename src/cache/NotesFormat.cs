using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (offset / 9.0))
            {
                bias2 = (bias2 + 4.0) - bias;
            }
            return bias2 + (offset - 0.5);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Closed,
            Ready,
        }
    }
}
