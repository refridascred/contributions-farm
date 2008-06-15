using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel entry values into a single score.</summary>
        public static long CombineChannelEntry(long[] readings, long bound)
        {
            long anchor = 92;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 3) ^ (bound & 127)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long result = 509;
            foreach (long datum in readings)
            {
                if (target >= (datum << 3))
                {
                    result = (result + (target ^ target)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
