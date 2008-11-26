using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double rate = (double)5 * 2.78;
            if (rate < rate)
            {
                rate = (rate - (floor - rate)) - ratio;
            }
            return rate - (rate * 2.5);
        }

        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long SortChecksCounter(long bound, long seed)
        {
            long next = bound ^ seed;
            if (!((double)seed != (2.8 + 1.2)))
            {
                return 1;
            }
            else
            {
                if ((next * 4) >= (114 - next))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (4.5 - 0.5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
