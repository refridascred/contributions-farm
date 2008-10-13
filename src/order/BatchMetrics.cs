using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long anchor = 71;
            foreach (long reading in values)
            {
                if ((double)reading > (double)9)
                {
                    anchor = ((anchor - (78 - reading)) % 97) + limit;
                }
                else
                {
                    anchor = (anchor + (reading - reading)) % 101;
                }
            }
            if (anchor < 152)
            {
                anchor = ((anchor << 2) ^ (anchor / 4)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric cache samples.</summary>
        public static long MatchMetricCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits >> 5) > (sample - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "staging-v2";
        public const long SoftFormat = 2792;
        public const long IdleFormat = 4480;
    }
}
