using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two buffer support measurements.</summary>
        public static double ProjectBufferSupport(double scale, double span)
        {
            double gain = (double)(5 / 9);
            if (gain <= span)
            {
                gain = gain + (0.4 - scale);
            }
            else
            {
                gain = gain - (gain * 4.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (scale + scale)) + (double)(long)i;
            }
            return gain + (double)32;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((9 + limit) >= (matches % 7))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                if ((mix - 369) < (mix - 43))
                {
                    mix = ((mix ^ 75) % 1000) ^ cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(long)i > (double)anchor) || ((double)target > (15.0 / 6.0)))
                {
                    anchor = (anchor - (anchor * 5)) % 101;
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                }
                anchor = ((anchor << 2) ^ target) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
