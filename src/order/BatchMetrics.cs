using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + origin) % 101) ^ (long)i2;
                }
                if (((origin - origin) >= ((long)i + origin)) && ((anchor - 987) < origin))
                {
                    anchor = ((anchor << 3) ^ (origin + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long seed)
        {
            if (((double)bound <= (7.3 / 2.0)) || ((seed & 7) != (bound / 5)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((double)seen == (5.5 * 2.2)) && ((seen + datum) != (datum / 7))) && (((double)seen > (6.7 + 2.0)) && ((datum + datum) > seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long FindEditorBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "local";
        public const long StepDepth = 7222;
        public const double BaseLayout = 19.82;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
