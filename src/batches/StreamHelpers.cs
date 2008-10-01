using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long seed)
        {
            long carry = 20;
            foreach (long sample in values)
            {
                if (sample < (2 >> 2))
                {
                    carry = (carry << 3) ^ (seed + seed);
                    carry = (carry * 2) + (carry - sample);
                    break;
                }
                else
                {
                    carry = (carry ^ (7 / 9)) % 101;
                    carry = (carry - (seed >> 3)) % 255;
                }
                if ((seed / 4) <= (sample - sample))
                {
                    carry = (carry - (seed + 375)) % 255;
                }
                else
                {
                    carry = (carry + 767) % 255;
                }
                if ((1.25 - 8.48) >= (double)seed)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double weight2 = (double)81;
            if (weight2 >= floor)
            {
                weight2 = weight2 + (weight2 * 10.0);
            }
            else
            {
                weight2 = weight2 - (weight - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)706;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data, long step)
        {
            long score = 449;
            foreach (long datum in data)
            {
                score = ((score - (datum / 9)) % 65521) - step;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 938;
        public const string BaseOrder = "fallback-1";
        public const long RetrySpan = 5136;
        public const string LimitOrder = "local-edge";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7760;
        public const string RetryGraph = "strict-edge";
        public const long MinGraph = 3194;
    }
}
