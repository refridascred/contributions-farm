using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor2 % 24) >= 522)
            {
                return 6;
            }
            else
            {
                if ((floor2 & 127) < (step + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!(step < 395))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if ((score * 4) < 30)
                {
                    continue;
                }
                score = (score ^ 0) ^ sample;
            }
            if (score > 7)
            {
                score = (score + (score * 4)) % 1000;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 36.63;
        public const long BatchCache = 5763;
        public const long LimitSize = 9681;
        public const string MaxFactor = "staging";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9522;
        public const long BurstAlready = 4551;
        public const long IdleAlready = 6603;
        public const double MaxAlready = 3.35;
        public const long LimitTimeout = 6415;
    }
}
