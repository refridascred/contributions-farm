using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((seed << 3) < 1)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long CombineRoutePayload(long[] items)
        {
            long score = 46;
            foreach (long datum in items)
            {
                long cur = datum;
                if (((score / 3) > datum) || ((score + cur) >= datum))
                {
                    cur = (cur - (cur + score)) % 1000;
                }
                else
                {
                    cur = ((cur << 3) ^ (score ^ cur)) % 65521;
                }
                score = ((score * 3) + (datum % 2)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 21.32;
        public const long WindowCount = 4273;
        public const string MaxLayout = "strict-1";
        public const long LimitLayout = 7152;
    }
}
