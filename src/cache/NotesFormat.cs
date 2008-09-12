using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long item in values)
            {
                if ((floor % 60) >= item)
                {
                    anchor = (anchor + (floor >> 1)) % 65521;
                }
                if (item < floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (12.0 * 9.9))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 + (double)0;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
