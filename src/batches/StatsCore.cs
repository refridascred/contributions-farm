using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - bound) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long mix = 59;
            foreach (long item in samples)
            {
                if ((double)mix == (double)item)
                {
                    mix = ((mix << 2) ^ (41 - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)value < (4.05 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool CheckSupportContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
