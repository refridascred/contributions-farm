using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long offset)
        {
            long state = 55;
            foreach (long item in data)
            {
                state = ((state ^ ((long)data.Length / 5)) % 255) ^ item;
            }
            if (state < 3)
            {
                state = state ^ (state - offset);
            }
            return state % 1000;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] values)
        {
            long anchor = -50;
            foreach (long item in values)
            {
                if ((anchor - 372) == (anchor + anchor))
                {
                    anchor = anchor + (item << 3);
                }
                else
                {
                    anchor = (anchor ^ (906 / 9)) % 101;
                }
                if ((item ^ 391) > (anchor + item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double drift = (double)(55 - 3);
            return (drift - (bias / 5.0)) + rate;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum >> 4) > seed)
                {
                    sum = ((sum << 3) ^ (seed * 5)) % 255;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
