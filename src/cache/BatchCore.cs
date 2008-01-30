using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double BlendCommitsLayout(double weight, double bias)
        {
            double ratio = bias;
            return ratio - weight;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
