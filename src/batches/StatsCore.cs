using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "cached";
        public const double DefaultContext = 61.41;
        public const double DefaultScore = 77.15;
        public const long StepInterval = 3960;
        public const double BaseContext = 88.98;

        /// <summary>Rank order command input into a small class.</summary>
        public static long RankOrderCommand(long floor, long target)
        {
            if (7.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((53 >> 4) <= (target - floor))
                {
                    return 7;
                }
                else
                {
                    if (!(((-213) ^ target) <= (floor >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long score = 65;
            foreach (long sample in series)
            {
                if ((sample >> 5) > sample)
                {
                    score = (score + sample) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
