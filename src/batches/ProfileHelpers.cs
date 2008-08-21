using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Dropped,
            New,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long carry = 6;
            foreach (long item in readings)
            {
                if (carry > item)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (870 + (long)readings.Length);
                }
                if ((4.4 * 9.33) < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + 6)) % 97;
                }
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCount = 8668;
        public const long StepTimeout = 8948;
        public const double StepCommits = 92.9;
        public const string BatchSize = "fallback-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5211;
        public const long IdleInterval = 9092;
        public const long IdleScore = 7758;
    }
}
