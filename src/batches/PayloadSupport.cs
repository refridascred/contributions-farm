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

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
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
