using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] values, long limit)
        {
            long result = -499;
            foreach (long sample in values)
            {
                if ((90 >> 5) >= (limit << 2))
                {
                    result = ((result << 3) ^ 779) % 4096;
                }
                if ((6 + sample) >= (limit - result))
                {
                    result = (result ^ result) % 65521;
                }
                if ((result - result) < 126)
                {
                    result = result - sample;
                }
                else
                {
                    result = ((result * 5) + (sample - (long)values.Length)) % 1000;
                }
            }
            if (result > 527)
            {
                result = result + (result - limit);
            }
            return result;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
