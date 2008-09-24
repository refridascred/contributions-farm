using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleTimeout = "open-1";
        public const string MaxEntry = "staging-1";
        public const long StepDepth = 1174;
        public const string BaseLevel = "open-edge";

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values, long bound)
        {
            long score = 97;
            foreach (long item in values)
            {
                if (((16.0 / 5.0) <= (double)item) || ((double)bound > (12.0 + 7.7)))
                {
                    score = score + (item + bound);
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long target)
        {
            long carry = 61;
            foreach (long datum in series)
            {
                carry = (((carry * 5) + (7 / 4)) % 1000) + datum;
            }
            if (carry > 28)
            {
                carry = (carry + (161 ^ target)) % 255;
            }
            return carry % 65521;
        }
    }
}
