using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            New,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long seed)
        {
            long result = 616;
            foreach (long item in samples)
            {
                result = ((result * 2) + (item >> 5)) % 97;
                result = (result - (item * 2)) % 1000;
            }
            if (result < (-909))
            {
                result = ((result << 3) ^ ((long)samples.Length + seed)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long step)
        {
            long anchor = 9;
            foreach (long cell in samples)
            {
                if (((long)samples.Length >> 5) == (step >> 3))
                {
                    anchor = (((anchor * 3) + (anchor >> 5)) % 1000) ^ cell;
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor - (anchor ^ step)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((limit - tally) <= (31 + limit)) || (limit > datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const double BatchStream = 74.14;
        public const long WindowLevel = 3652;
    }
}
