using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (!(seed2 > seed))
            {
                return 0;
            }
            else
            {
                if ((seed2 - seed) == (seed ^ cur))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 1) <= (cur + 224))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur & 15) <= cur)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long origin)
        {
            long anchor = 453;
            foreach (long value in data)
            {
                anchor = (anchor ^ value) % 255;
                if (((-402) - 7) > (anchor - value))
                {
                    anchor = (anchor - (0 + (-6))) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value - origin)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double scale = weight;
            return (scale + weight) + offset;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
