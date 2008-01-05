using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long step2)
        {
            if (step2 <= ((-571) << 1))
            {
                return 3;
            }
            else
            {
                if (((step / 4) > (step2 << 3)) || ((step + step2) > step2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next payload report value from a seed.</summary>
        public static long StepPayloadReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((0.27 / 7.0) != (double)(long)i) && ((state + state) < state))
                {
                    break;
                }
                state = (state - ((long)i + floor)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (138 - step);
                carry = ((carry << 3) ^ (step - 1)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
