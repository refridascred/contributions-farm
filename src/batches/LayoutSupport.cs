using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (floor * 19.0) + (1.6 - 3.3);
            if (scale < 8.04)
            {
                scale = (scale - (scale / 6.0)) + bias;
            }
            return scale + floor;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long TotalCounterStream(long[] values)
        {
            long result = 96;
            foreach (long sample in values)
            {
                if ((result / 5) < (result ^ result))
                {
                    result = ((result * 5) + (result + sample)) % 65521;
                    break;
                }
                if (((result - sample) > (sample - result)) || (sample < result))
                {
                    result = ((result * 5) + (result * 2)) % 97;
                }
                result = (result ^ (sample >> 3)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Locked,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
