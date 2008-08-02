using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the notes session entries that pass the check.</summary>
        public static long MeasureNotesSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits + 340) < value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long GradeStreamContext(long offset, long bound)
        {
            long delta = offset ^ bound;
            if (((delta - delta) > delta) || ((delta >> 2) == (206 & 31)))
            {
                return 6;
            }
            else
            {
                if ((879 << 3) == (bound * 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
