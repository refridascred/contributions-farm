using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstScore = 2632;
        public const long BatchDepth = 3964;
        public const long MaxSize = 9346;
        public const double IdleWidth = 1.04;
        public const string StepCounter = "standard-edge";

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long seed)
        {
            long acc = 21;
            foreach (long reading in data)
            {
                if (8.7 < (double)(long)data.Length)
                {
                    acc = ((acc << 3) ^ (seed + 4)) ^ reading;
                }
                else
                {
                    acc = (acc - (73 + 4)) % 4096;
                }
            }
            if (acc > 505)
            {
                acc = acc ^ (acc + 54);
            }
            return acc % 65521;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long mix = 291;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.17 / 2.0))
                {
                    mix = ((mix * 3) + 114) % 97;
                }
            }
            if (mix < 49)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
