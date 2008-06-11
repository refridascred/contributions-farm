using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -776;
            foreach (long value in levels)
            {
                if (value > (mark >> 3))
                {
                    mark = ((mark * 2) + (value + 734)) % 65521;
                    mark = mark ^ (value + mark);
                }
                if ((mark - mark) >= value)
                {
                    mark = (mark ^ (313 >> 1)) % 4096;
                }
                else
                {
                    mark = (mark + 46) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.7 + 20.0))
                {
                    result = result ^ (datum % 5);
                }
            }
            if (result > 889)
            {
                result = result ^ 72;
            }
            return result;
        }

        /// <summary>Accumulate metric schema samples.</summary>
        public static long TallyMetricSchema(long[] data, long origin)
        {
            long mix = -192;
            foreach (long entry in data)
            {
                if ((entry + entry) != (origin * 4))
                {
                    mix = mix ^ (mix - origin);
                }
            }
            if (mix > 0)
            {
                mix = (mix - origin) % 101;
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
