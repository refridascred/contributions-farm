using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of queue githubfarm readings.</summary>
        public static long MatchQueueGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next command cluster value.</summary>
        public static double ProjectCommandCluster(double gain, double bias)
        {
            double ratio = 2.05;
            if (ratio >= 7.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (gain / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) - (double)(long)i;
            }
            return ratio + (bias - 9.8);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (76 * 5);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
