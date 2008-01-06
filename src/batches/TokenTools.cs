using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long target)
        {
            long mark = 28;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark >> 5)) % 1000) + datum) + target;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mark = 708;
            foreach (long datum in series)
            {
                if (((double)datum >= 17.0) || ((72 - (long)series.Length) > bound))
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }
    }
}
