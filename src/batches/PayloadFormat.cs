using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double ratio2 = (double)(250 - 11);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (ratio2 - 9.5)) - (double)(long)i) - offset;
            }
            return ratio2 + ratio;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Pending,
            Queued,
        }
    }
}
