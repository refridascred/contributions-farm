using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long BucketFilterFormat(long origin, long limit)
        {
            long diff = origin + limit;
            if (origin <= (diff << 3))
            {
                return 2;
            }
            else
            {
                if ((limit & 31) > origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + diff) >= (440 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Paused,
            Stale,
            New,
            Locked,
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Done,
            Draft,
        }
    }
}
