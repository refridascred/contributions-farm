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

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = 44;
            foreach (long entry in readings)
            {
                if ((anchor ^ anchor) != (anchor % 60))
                {
                    anchor = anchor + (6 / 2);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry % 16)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ (1 * 4)) % 65521;
            }
            return anchor % 4096;
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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long step)
        {
            long diff = offset ^ step;
            if ((step << 3) <= step)
            {
                return 3;
            }
            else
            {
                if ((double)diff >= (17.0 - 5.5))
                {
                    return 0;
                }
                else
                {
                    if (step < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
