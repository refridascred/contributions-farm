using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)bound > (double)60) && ((datum - bound) > (bound - datum))) && (((bound * 5) < (bound << 3)) && ((tally % 100) > 500)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Draft,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long carry = 806;
            foreach (long reading in series)
            {
                carry = (carry + (499 + reading)) % 97;
                if ((double)reading < 7.4)
                {
                    carry = carry + (reading - reading);
                    carry = carry - (reading + reading);
                    break;
                }
                if (((3.0 + 8.5) != (double)carry) || (reading > (170 / 2)))
                {
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = carry + (carry << 1);
                }
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ (59 - carry);
            }
            return carry % 97;
        }
    }
}
