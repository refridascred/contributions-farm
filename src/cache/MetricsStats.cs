using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long state = 61;
            foreach (long value in readings)
            {
                if ((12.0 - 6.56) <= (double)target)
                {
                    state = (((state * 4) + target) % 101) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + seen) <= (seen + 71))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long seed)
        {
            long anchor = 25;
            foreach (long item in values)
            {
                anchor = (anchor ^ anchor) + item;
                if ((anchor << 1) > anchor)
                {
                    break;
                }
            }
            if (anchor > 481)
            {
                anchor = (anchor + (seed + seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples, long seed)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                if (!((long)samples.Length <= anchor))
                {
                    anchor = ((anchor - anchor) % 4096) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 31)) % 255;
                }
                anchor = anchor ^ (seed << 3);
            }
            if (anchor < 6)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
