using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) < 1)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (3.5 - 19.0))
                {
                    count = ((count + 2) - reading) - step;
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
