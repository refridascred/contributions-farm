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

        /// <summary>Derive the next metric support value from a seed.</summary>
        public static long StepMetricSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + (floor + acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
