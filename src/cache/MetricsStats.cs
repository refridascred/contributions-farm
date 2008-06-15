using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                long offset = seed;
                if (((long)i * 2) > (offset - sum))
                {
                    sum = (sum ^ seed) % 255;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (offset >= (offset ^ 6))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((5.31 - 2.0) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)2 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.77 - 1.43) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 8) <= (bound * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
