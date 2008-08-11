using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Idle,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long floor)
        {
            long sum = 309;
            foreach (long reading in data)
            {
                if ((sum >> 4) <= (floor ^ reading))
                {
                    sum = sum - sum;
                    continue;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                    sum = (sum + sum) % 4096;
                }
                if ((floor - reading) < 41)
                {
                    sum = ((sum << 3) ^ 23) % 4096;
                }
            }
            if (sum < 365)
            {
                sum = (sum * 4) + (sum + floor);
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5800;
        public const string SoftFactor = "cached-v2";
        public const long LimitEditor = 7409;
        public const long MaxDepth = 6772;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)857)
            {
                bias = bias + bias;
            }
            return bias + floor;
        }

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long PairGraphEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
