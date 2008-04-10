using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Synced,
            New,
            Failed,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((seed & 31) == (seed % 100))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long AuditLayoutCacheGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)step >= (3.3 + 5.0)) && ((step ^ count) >= (step + count)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double AdjustChannelStats(double weight, double offset)
        {
            double scale = weight;
            if (scale <= offset)
            {
                scale = scale - 5.34;
            }
            return scale + 7.56;
        }
    }
}
