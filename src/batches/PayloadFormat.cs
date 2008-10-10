using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ sample) % 4096;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (step / 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 4183;
        public const string RetryMetric = "primary-1";
        public const long DefaultMetric = 9457;
        public const string MinMetric = "staging-1";

        /// <summary>Check that every editor batches entry stays within the limit.</summary>
        public static bool GuardEditorBatchesBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public bool Owner { get; set; }
        }
    }
}
