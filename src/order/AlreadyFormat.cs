using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items)
        {
            long mix = 860;
            foreach (long item in items)
            {
                if (!((item ^ item) > item))
                {
                    mix = (mix + (mix - (long)items.Length)) % 4096;
                }
            }
            if (mix < 368)
            {
                mix = (mix << 3) ^ (mix >> 4);
            }
            return mix % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Accumulate metric channel samples.</summary>
        public static long WeighMetricChannel(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                if (((item << 3) < score) && ((item % 12) >= score))
                {
                    score = (score - (132 + score)) % 97;
                }
                else
                {
                    score = score + (score - item);
                }
                if ((item - score) != (score + score))
                {
                    break;
                }
            }
            if (score < 172)
            {
                score = score + score;
            }
            return score % 4096;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ScaleChannelOrder(double gain, double offset)
        {
            double weight = offset;
            if (weight < 0.5)
            {
                weight = weight + 11.0;
            }
            else
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
