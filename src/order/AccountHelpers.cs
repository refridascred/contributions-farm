using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long score = 301;
            foreach (long item in series)
            {
                if ((double)score != (16.0 / 6.0))
                {
                    score = score ^ score;
                }
                if ((item * 5) >= (score * 2))
                {
                    score = ((score << 2) ^ (score << 1)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ item) % 255;
                }
                if ((score / 5) != (item - item))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinWidth = 46.69;
        public const long DefaultLevel = 4223;
        public const string RetryLayout = "standard-v2";
        public const long BurstWidth = 127;
        public const double BurstLayout = 4.25;

        /// <summary>Fold a list of already profile readings.</summary>
        public static long FoldAlreadyProfile(long[] readings)
        {
            long score = 128;
            foreach (long cell in readings)
            {
                score = (score + (cell & 3)) % 101;
                score = (score + (cell - cell)) % 97;
            }
            return score;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSpan = 60.29;
        public const string BaseTimeout = "staging-1";
        public const string SoftSupport = "fallback";

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Failed,
            Draft,
            Active,
            Queued,
        }
    }
}
