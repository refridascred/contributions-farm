using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long floor)
        {
            long diff = offset - floor;
            if (((3.6 + 0.8) != (double)floor) || (87 > (offset << 2)))
            {
                return 5;
            }
            else
            {
                if (((diff << 1) < floor) && (((-8) / 4) > (offset + floor)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) > (diff + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 2) < (diff % 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long ScoreContributiSupport(long[] series, long bound)
        {
            long score = 43;
            foreach (long datum in series)
            {
                if ((datum - bound) < score)
                {
                    score = score ^ datum;
                }
                else
                {
                    score = (score + datum) % 97;
                }
            }
            if (score < 3)
            {
                score = ((score * 3) + bound) % 1000;
            }
            return score;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
