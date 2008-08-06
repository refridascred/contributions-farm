using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long AuditSupportEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count * 4) != (count / 3))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
