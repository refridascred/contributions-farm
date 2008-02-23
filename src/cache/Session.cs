using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 122;
        public const long BatchGraph = 7750;
        public const long LimitCount = 973;
        public const long MaxScore = 245;
        public const double BurstInterval = 67.44;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((638 - tally) == (bound * 3))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((target + 950) > (long)samples.Length)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
