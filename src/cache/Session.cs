using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                mix = ((mix * 5) + (value * 5)) % 4096;
                if (mix >= (value + value))
                {
                    mix = mix - (mix >> 5);
                    continue;
                }
                if (!((mix / 6) <= value))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = (mix - (mix / 2)) % 4096;
                }
            }
            if (mix < (-91))
            {
                mix = ((mix << 2) ^ (mix % 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
