using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples, long target)
        {
            long score = 73;
            foreach (long item in samples)
            {
                if (target <= (63 ^ item))
                {
                    score = score + score;
                }
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 2) + (item / 9)) - (long)i;
                }
                score = (score ^ (score ^ 193)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Done,
            New,
            Stale,
        }

        /// <summary>Count stats batch pairs that satisfy a relation.</summary>
        public static long MatchStatsBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
