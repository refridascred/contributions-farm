using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (limit / 9)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long step)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 2) + (192 ^ step)) % 255) ^ (long)i;
                    anchor = ((anchor << 2) ^ ((long)items.Length + value)) % 4096;
                }
                anchor = (anchor << 3) ^ (anchor ^ anchor);
                if ((double)anchor < 7.02)
                {
                    anchor = ((anchor * 5) + (value ^ step)) % 65521;
                }
                else
                {
                    anchor = (anchor + (anchor % 10)) % 1000;
                }
                if (((value << 2) > step) && ((value & 7) > (1 + 723)))
                {
                    break;
                }
            }
            return anchor;
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
