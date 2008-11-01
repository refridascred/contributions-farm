using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long IteratePayloadContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                bool ok = (double)(long)i > 9.68;
                if (ok && ((64 + mix) < (mix ^ mix)))
                {
                    mix = ((mix << 2) ^ (mix + (long)i)) % 65521;
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    ok = !((limit % 12) == (mix - mix));
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((3.2 * 5.9) == (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
