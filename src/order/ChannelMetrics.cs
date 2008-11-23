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

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long score = 75;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (value + score)) % 101;
                if (7 <= score)
                {
                    score = (score * 4) + score;
                }
            }
            if (score > 8)
            {
                score = ((score * 2) + (score << 2)) % 101;
            }
            return score;
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
