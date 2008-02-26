using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile counter entry that matches the target.</summary>
        public static long LocateProfileCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mark = 79;
            foreach (long item in readings)
            {
                if (((7.7 - 8.0) <= (double)item) && ((5.36 * 14.0) <= (double)mark))
                {
                    mark = mark ^ (mark - item);
                }
                if ((71 >= item) && ((mark * 3) < (item & 255)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark - ((-45) + mark)) % 97;
            }
            return mark % 1000;
        }
    }
}
