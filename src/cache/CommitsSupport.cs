using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = (double)(76 ^ 7);
            if (bias >= scale)
            {
                bias = bias + span;
            }
            return bias - (double)710;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long sum = 33;
            foreach (long sample in readings)
            {
                if ((sum + sample) >= ((-9) ^ sample))
                {
                    sum = ((sum << 2) ^ (sample + sample)) % 255;
                }
                else
                {
                    sum = sum ^ (step / 6);
                }
                if ((double)29 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long TallySchemaCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((4.7 - 2.66) < (double)seen) && (sample > ((-711) + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] levels, long bound)
        {
            long anchor = 21;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 2) ^ (long)levels.Length) ^ (long)i) - bound;
                }
                anchor = anchor ^ (item >> 4);
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 65521;
        }
    }
}
