using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of token report entries.</summary>
        public static long WeighTokenReport(long[] levels)
        {
            long total = -506;
            foreach (long sample in levels)
            {
                total = ((total * 3) + (sample / 2)) % 97;
                total = (total * 3) + total;
            }
            if (total > 937)
            {
                total = total ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((target << 2) == (sample / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 6.71;
        public const long BatchBudget = 7280;
        public const double HardSupport = 64.92;
        public const long CacheSize = 7073;
        public const double BaseInterval = 92.63;

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
