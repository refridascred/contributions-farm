using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = (carry * 4) + (item * 3);
                if ((double)item != (9.33 / 4.0))
                {
                    carry = ((carry * 5) + ((-1) << 1)) % 97;
                }
            }
            if (carry < 553)
            {
                carry = ((carry << 2) ^ (2 + carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 3243;
        public const long DefaultSession = 2038;
        public const long StepSession = 5012;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate githubfarm context samples.</summary>
        public static long FoldGithubfarmContext(long[] readings, long origin)
        {
            long carry = 22;
            foreach (long sample in readings)
            {
                if ((double)sample <= (11.0 + 5.3))
                {
                    carry = (carry << 2) ^ (origin + 264);
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ (origin - carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
