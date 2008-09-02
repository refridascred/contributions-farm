using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel counter series from a seed.</summary>
        public static long IterateChannelCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                bool valid = (double)score <= (1.31 - 7.0);
                if (!valid)
                {
                    break;
                }
                else
                {
                    valid = score <= (score - (long)i);
                }
                if ((seed + score) > score)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long limit)
        {
            long sum = 26;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sample + sample)) % 255) - limit;
            }
            return sum % 1000;
        }
    }
}
