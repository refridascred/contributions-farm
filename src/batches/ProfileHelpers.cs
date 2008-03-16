using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Locked,
            New,
            Stale,
            Draft,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 865;
            foreach (long datum in readings)
            {
                if ((double)carry != (double)291)
                {
                    carry = (carry * 4) + carry;
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = carry + (datum << 1);
                    carry = (carry * 3) + (40 / 9);
                }
                if (((carry & 7) > 928) || (carry < (datum ^ datum)))
                {
                    carry = (carry * 5) + (carry % 64);
                }
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long mix = 615;
            foreach (long datum in samples)
            {
                mix = (mix << 3) ^ datum;
                if ((double)datum > 3.6)
                {
                    break;
                }
            }
            if (mix > 610)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ ((long)i % 24);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
