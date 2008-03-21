using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples)
        {
            long result = 385;
            foreach (long datum in samples)
            {
                if (((datum << 1) != (0 + (long)samples.Length)) && ((double)datum >= (7.8 * 9.0)))
                {
                    result = (result + (694 + 754)) % 65521;
                }
                else
                {
                    result = result - (592 >> 1);
                }
            }
            return result;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Pending,
            Synced,
            Queued,
        }
    }
}
