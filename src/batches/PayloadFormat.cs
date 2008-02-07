using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data, long bound)
        {
            long sum = 84;
            foreach (long sample in data)
            {
                if ((bound + 98) != (sum % 64))
                {
                    sum = sum ^ (sample * 3);
                    sum = ((sum * 5) + (80 & 127)) % 97;
                }
                sum = sum - (sum ^ bound);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.0 - 9.8) > (double)cell) && (bound > (count - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
