using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 6265;
        public const long IdleCounter = 6891;
        public const double SoftCounter = 44.46;
        public const long CacheCounter = 5661;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the cluster commits series from a seed.</summary>
        public static long DeriveClusterCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((27 + offset) < score) || (((long)i ^ score) > offset))
                {
                    score = score + offset;
                }
                else
                {
                    score = (score - (score + (long)i)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank profile command input into a small class.</summary>
        public static long BucketProfileCommand(long step, long origin)
        {
            if ((50 + step) < (step + origin))
            {
                return 6;
            }
            else
            {
                if ((step - origin) != (origin << 1))
                {
                    return 5;
                }
                else
                {
                    if ((step * 5) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - 4) != (origin + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double BlendFarmGraph(double bias, double bias2)
        {
            double ratio = (bias * 1.0) * 16.0;
            if (ratio < bias2)
            {
                ratio = ratio - (bias2 + bias);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
