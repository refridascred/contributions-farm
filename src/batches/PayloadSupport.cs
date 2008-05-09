using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Combine checks stats values into a single score.</summary>
        public static long TotalChecksStats(long[] data)
        {
            long result = 796;
            foreach (long entry in data)
            {
                if (((result ^ entry) >= entry) && ((result + result) == (result % 8)))
                {
                    result = (result + result) % 65521;
                }
            }
            if (result < 2)
            {
                result = (result + (result + 37)) % 65521;
            }
            return result;
        }

        /// <summary>Blend two entry token measurements.</summary>
        public static double ProjectEntryToken(double scale, double offset)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean + mean) + scale;
            }
            return mean + offset;
        }
    }
}
