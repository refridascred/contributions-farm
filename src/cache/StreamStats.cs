using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if (bound >= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((limit ^ limit) == (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (833 <= (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)39)
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (gain * 1.6)) - (double)(long)i;
            }
            return bias + (double)2;
        }
    }
}
