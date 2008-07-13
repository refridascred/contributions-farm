using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long CountPayloadChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count ^ (-21)) == (count >> 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long MeasureOrderRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum <= (260 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "alpha-v2";
        public const long RetryBuffer = 4417;
        public const long HardBudget = 6041;
        public const long HardBuffer = 7024;
        public const string StepFactor = "standard-1";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((double)value >= (4.6 / 6.0)) && ((count + value) >= ((long)levels.Length >> 3))) || ((count - value) > (value & 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
