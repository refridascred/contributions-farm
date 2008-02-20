using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report order samples are out of range.</summary>
        public static long TallyReportOrderGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((-7) + offset) > cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ (121 & 127)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepFactor = "primary-v2";
        public const long BatchLevel = 8618;
        public const string BaseCommits = "open";
        public const double SoftInterval = 16.38;
    }
}
