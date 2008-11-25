using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long result = 603;
            foreach (long item in readings)
            {
                if ((8.24 + 3.73) >= (double)result)
                {
                    result = ((result << 3) ^ (result + result)) % 97;
                }
                else
                {
                    result = (result + (item - (-952))) % 65521;
                }
            }
            if (result < 46)
            {
                result = (result - (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
