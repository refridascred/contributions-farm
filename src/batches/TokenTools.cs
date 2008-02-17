using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long target)
        {
            long acc = 738;
            foreach (long datum in series)
            {
                if ((datum & 63) == (datum % 8))
                {
                    acc = (acc - (datum - acc)) - target;
                }
                else
                {
                    acc = ((acc << 3) ^ (datum - datum)) % 65521;
                }
                if ((double)acc == (14.0 * 9.07))
                {
                    break;
                }
            }
            if (acc > 39)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long BucketReportNotes(long step, long floor)
        {
            if ((13.0 / 3.0) == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((30 / 2) == (step + step)) && ((double)floor != (4.96 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 3) <= (391 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)step == (5.9 + 9.77)))
                        {
                            return 2;
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
