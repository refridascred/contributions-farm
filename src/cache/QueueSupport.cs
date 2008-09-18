using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long target)
        {
            long gap = offset + target;
            if (!((target + gap) >= (offset ^ offset)))
            {
                return 2;
            }
            else
            {
                if (!(5.96 <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (offset ^ gap)) && ((offset & 7) < target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a cache githubfarm reading.</summary>
        public static double ProjectCacheGithubfarm(double bias, double offset)
        {
            double weight = (bias - offset) + offset;
            if (weight <= bias)
            {
                weight = weight - (8.2 - 12.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)36) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples, long target)
        {
            long mix = 44;
            foreach (long reading in samples)
            {
                mix = mix + (reading << 2);
                if (((mix * 3) <= (target - reading)) || ((8.92 + 5.3) == (double)mix))
                {
                    mix = (mix + ((long)samples.Length * 4)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
