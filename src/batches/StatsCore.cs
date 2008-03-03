using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double drift = 3.5;
            if (drift > (3.3 * 9.0))
            {
                drift = (drift + drift) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score + (datum ^ 97)) % 1000) - target;
            }
            if (score < 49)
            {
                score = (score + (score << 1)) % 255;
            }
            return score;
        }

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 6540;
        public const long MinGithubfarm = 7226;
        public const long CacheTimeout = 983;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((sum * 5) == (32 >> 1))
                {
                    long step = 540;
                    sum = ((sum * 4) + step) % 65521;
                    break;
                }
                else
                {
                    sum = (sum ^ (-158)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
