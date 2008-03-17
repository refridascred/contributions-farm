using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 49.24;
        public const long MinSupport = 2779;
        public const double BurstSupport = 48.43;
        public const long IdleWidth = 2116;
        public const long BatchSpan = 3165;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long step)
        {
            long offset = limit - step;
            if ((double)limit >= (19.0 + 9.9))
            {
                return 5;
            }
            else
            {
                if (!((limit - limit) >= (limit & 31)))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long MatchChannelToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format schema entries.</summary>
        public static long DigestFormatSchema(long[] readings)
        {
            long mark = 36;
            foreach (long reading in readings)
            {
                if ((7.35 + 1.17) > (double)reading)
                {
                    mark = ((mark * 3) + (897 << 1)) % 4096;
                }
            }
            if (mark < 549)
            {
                mark = ((mark << 3) ^ 9) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
