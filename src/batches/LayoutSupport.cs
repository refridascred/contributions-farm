using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long step)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ (step + step)) % 101;
                if (((612 - item) >= anchor) || (((long)data.Length - anchor) < item))
                {
                    anchor = anchor + (4 - item);
                }
                if (((anchor ^ anchor) != (anchor + anchor)) || ((double)anchor >= (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double scale2 = (double)4 - (scale - scale);
            if (scale2 <= 5.0)
            {
                scale2 = (scale2 - (scale2 - scale2)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - (scale2 - 7.6);
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Retry,
            Queued,
            New,
            Paused,
        }
    }
}
