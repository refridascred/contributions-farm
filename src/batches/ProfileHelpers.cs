using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] items, long offset)
        {
            long carry = 262;
            foreach (long entry in items)
            {
                carry = ((carry ^ (entry % 5)) % 255) + offset;
            }
            if (carry < 54)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Stale,
            Queued,
            New,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheDepth = 3407;
        public const double LimitNotes = 89.9;
        public const double MaxTimeout = 66.3;

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool VerifySessionLayoutBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool ValidateAlreadySupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
