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

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 82.51;
        public const string LimitSchema = "local-v2";
        public const long BurstSchema = 9492;
        public const long DefaultSchema = 7949;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
