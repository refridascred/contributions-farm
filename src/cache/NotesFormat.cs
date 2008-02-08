using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 >= (scale / 6.0))
            {
                scale2 = (scale2 - scale2) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (18.0 / 6.0)) + (double)(long)i;
            }
            return scale2 + (scale - scale2);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 502;
            foreach (long value in levels)
            {
                result = ((result << 2) ^ (result % 5)) % 255;
                result = ((result * 5) + (result ^ value)) % 4096;
            }
            if (result < 8)
            {
                result = ((result << 3) ^ (result & 127)) % 101;
            }
            return result % 4096;
        }
    }
}
