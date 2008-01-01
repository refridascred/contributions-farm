using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9999;
        public const double StepBuffer = 97.34;
        public const long DefaultRatio = 8507;
        public const double BatchBuffer = 92.89;

        /// <summary>Rank contributi token input into a small class.</summary>
        public static long BucketContributiToken(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((floor + seed) > (floor & 31))
            {
                return 0;
            }
            else
            {
                if (cur < seed)
                {
                    return 6;
                }
                else
                {
                    if ((cur + floor) >= (floor & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor * 5) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                if ((carry / 5) >= sample)
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry > 51)
            {
                carry = (carry * 4) + (97 * 4);
            }
            return carry;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state + bound;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
