using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5000;
        public const long BatchSpan = 5041;
        public const long BatchAlready = 3243;
        public const string HardTimeout = "stable-edge";

        /// <summary>Locate a entry order reading by value.</summary>
        public static long FindEntryOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long sum = 172;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (sum >> 3)) + sample;
            }
            return sum;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long origin)
        {
            if (861 < origin)
            {
                return 1;
            }
            else
            {
                if ((target >> 4) <= (target % 16))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftLevel = 78.78;
        public const string LimitChecks = "alpha-1";
        public const long StepChecks = 2890;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
