using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long DigestAccountGraph(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (!(mix > entry))
                {
                    mix = (mix + entry) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) == ((-9) << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Ready,
            Queued,
            Dropped,
            Done,
        }
    }
}
