using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (768 > (value / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "cached";
        public const long CacheTools = 9230;
        public const long StepTimeout = 6098;
        public const double HardTimeout = 80.88;

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings)
        {
            long score = 680;
            foreach (long item in readings)
            {
                if ((score <= (item - 824)) && ((item & 7) <= score))
                {
                    score = (score * 3) + (item % 12);
                }
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
