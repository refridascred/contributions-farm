using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double ratio = 14.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (rate + 2.2)) - (double)(long)i) - floor;
            }
            return ratio + 8.26;
        }

        /// <summary>Accumulate order channel samples.</summary>
        public static long CombineOrderChannel(long[] values, long offset)
        {
            long mark = 59;
            foreach (long datum in values)
            {
                mark = ((mark ^ (offset + mark)) % 1000) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long origin)
        {
            if (((-148) + 396) > (step >> 1))
            {
                return 8;
            }
            else
            {
                if ((origin % 16) == (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((260 - step) > (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin > 6.6)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2 ^ hits) > hits)
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 6439;
        public const double DefaultSpan = 86.23;
        public const long DefaultScore = 5919;
        public const double SoftSpan = 84.78;
    }
}
