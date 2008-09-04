using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double ratio = span * 2.8;
            if (ratio <= (span * 3.23))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (ratio - 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (rate - rate)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long step)
        {
            long lane = floor ^ step;
            if ((double)floor < 4.5)
            {
                return 3;
            }
            else
            {
                if (((step % 100) <= step) && (lane < step))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) <= (lane ^ step))
                    {
                        return 5;
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
