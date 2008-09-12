using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            if (!((double)9 < (double)limit2))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (15.0 - 4.4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc > 97) && ((acc - step) != ((long)i - step))))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                acc = (acc + step) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell >= (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
