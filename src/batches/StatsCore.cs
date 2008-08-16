using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseInterval = 1238;
        public const long BurstToken = 6727;
        public const double LimitBudget = 53.42;
        public const long MinSize = 6464;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)27 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long acc = 349;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= reading)
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 101;
                }
                acc = acc ^ (acc - reading);
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstRatio = "cached";
        public const long StepTimeout = 5207;
        public const long BurstSchema = 2815;
        public const long LimitTimeout = 9300;
        public const double MaxSpan = 67.14;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ 5) % 255;
                if ((total + 9) >= step)
                {
                    total = (total - (total + total)) % 65521;
                    break;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
