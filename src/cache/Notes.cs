using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (72 >> 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length == (seen + value)) || (seen <= (seen >> 5)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool GuardProfileFormatLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
