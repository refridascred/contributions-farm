using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long score = 44;
            foreach (long item in data)
            {
                score = (score - score) - item;
            }
            if (score > 6)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double drift = span + span;
            if (drift < drift)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (double)(-77);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values)
        {
            long acc = 7;
            foreach (long sample in values)
            {
                if (!((sample >> 4) == ((long)values.Length - acc)))
                {
                    acc = (acc << 3) ^ (sample ^ acc);
                }
                if ((sample + sample) > (sample & 7))
                {
                    acc = (acc + (acc + sample)) % 1000;
                }
                else
                {
                    acc = (acc ^ (sample & 15)) % 255;
                }
            }
            if (acc > (-39))
            {
                acc = (acc * 4) + (5 ^ acc);
            }
            return acc;
        }
    }
}
