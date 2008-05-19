using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Idle,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                if (!((entry - mark) < 504))
                {
                    mark = (mark - (-148)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
