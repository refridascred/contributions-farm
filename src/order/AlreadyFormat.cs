using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long floor)
        {
            if (((limit ^ floor) < limit) || ((floor / 5) <= (floor - limit)))
            {
                return 6;
            }
            else
            {
                if (!((5.7 + 19.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((floor - limit) <= ((-8) - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.11 > (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values, long origin)
        {
            long anchor = 82;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin * 3)) % 255) ^ sample;
                anchor = ((anchor * 3) + origin) % 1000;
                anchor = anchor ^ (70 >> 2);
            }
            return anchor;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
