using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double load = floor * 15.0;
            if (load <= (load - 8.25))
            {
                load = (load - load) - bias;
            }
            else
            {
                load = load - (double)252;
            }
            return load + 9.79;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count * 5) >= sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entry entries.</summary>
        public static long TotalChannelEntry(long[] series)
        {
            long carry = 340;
            foreach (long sample in series)
            {
                if (((7.46 * 5.56) >= (8.0 - 1.0)) && ((double)carry != (9.0 / 7.0)))
                {
                    break;
                }
                carry = (carry - (carry * 4)) - sample;
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] samples)
        {
            long total = 388;
            foreach (long item in samples)
            {
                total = total - item;
                if ((item & 3) == (item % 3))
                {
                    total = ((total << 3) ^ (item % 100)) % 101;
                }
            }
            return total;
        }
    }
}
