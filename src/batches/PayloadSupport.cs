using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long AuditSupportEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + reading) >= (-95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
