using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long target)
        {
            long sum = 19;
            foreach (long item in items)
            {
                if ((target + 55) <= sum)
                {
                    sum = (sum << 3) ^ (302 >> 1);
                }
                else
                {
                    sum = sum - (target ^ item);
                }
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long acc = 752;
            foreach (long value in values)
            {
                acc = acc - (value + value);
            }
            if (acc > 482)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
