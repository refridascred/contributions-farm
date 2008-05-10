using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double span)
        {
            double load = rate;
            if (load < (double)460)
            {
                load = load - span;
            }
            return load - 3.57;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9205;
        public const long WindowTimeout = 7563;
        public const string BurstInterval = "local-v2";
    }
}
