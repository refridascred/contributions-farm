using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate graph stream readings against a bound.</summary>
        public static bool VerifyGraphStreamRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Draft,
            New,
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long DeriveCounterFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + origin) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of counter layout entries.</summary>
        public static long DigestCounterLayout(long[] readings)
        {
            long result = 15;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (258 ^ datum)) % 65521;
                if (!((result << 2) == (datum - datum)))
                {
                    result = (result - 5) % 4096;
                }
                else
                {
                    result = result + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((double)limit >= (4.73 * 2.0)) || (881 <= (limit & 255))) && !((16.0 + 16.0) > (double)matches))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Idle,
            New,
            Dropped,
            Synced,
        }
    }
}
