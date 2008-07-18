using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 881;
            foreach (long datum in levels)
            {
                if ((datum ^ state) < (state & 63))
                {
                    state = (state ^ 685) % 65521;
                }
                if (!(5.4 < (double)datum))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2873;
        public const long HardFarm = 9090;
        public const double SoftFarm = 57.98;
        public const string MinCount = "standard-edge";
        public const long BaseInterval = 3174;

        /// <summary>Fold a list of layout metric readings.</summary>
        public static long DigestLayoutMetric(long[] series)
        {
            long total = 23;
            foreach (long datum in series)
            {
                if ((250 < (total + (long)series.Length)) || ((datum + total) > datum))
                {
                    total = (total + datum) % 1000;
                }
                else
                {
                    total = total + (datum & 255);
                }
            }
            return total;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long target)
        {
            long carry = 1;
            foreach (long sample in levels)
            {
                carry = carry ^ carry;
                if ((0.96 + 1.86) == (double)carry)
                {
                    carry = ((carry * 3) + target) % 4096;
                }
                if ((85 - sample) != (target / 7))
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (carry & 31)) % 101;
            }
            return carry;
        }
    }
}
