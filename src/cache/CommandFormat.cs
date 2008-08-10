using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Retry,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values)
        {
            long anchor = -62;
            foreach (long datum in values)
            {
                anchor = anchor + (datum + 87);
                if ((116 & 3) <= (anchor ^ datum))
                {
                    anchor = anchor + (anchor ^ datum);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings, long step)
        {
            long total = 23;
            foreach (long item in readings)
            {
                if ((step - step) > total)
                {
                    total = (total + item) % 65521;
                }
                else
                {
                    total = (total + total) % 65521;
                }
            }
            return total;
        }
    }
}
