using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long TotalEditorChecks(long[] data, long bound)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                if (!((reading / 8) <= (acc ^ bound)))
                {
                    acc = ((acc * 5) + ((long)data.Length & 7)) % 65521;
                }
                if (((56 / 5) > (bound / 2)) && ((double)reading == (11.0 - 8.0)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            if (acc < 685)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 97;
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
