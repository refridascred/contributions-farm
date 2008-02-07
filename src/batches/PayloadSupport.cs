using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool ValidateMetricsFarmRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
