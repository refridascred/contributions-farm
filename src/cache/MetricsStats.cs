using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long total = 268;
            foreach (long value in data)
            {
                total = ((total * 5) + value) + seed;
            }
            return total % 97;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - offset) >= (count - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record payload entries.</summary>
        public static long TotalRecordPayload(long[] series, long offset)
        {
            long carry = 37;
            foreach (long reading in series)
            {
                carry = ((((carry * 3) + ((-50) & 127)) % 101) + reading) + offset;
            }
            return carry;
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long GradeGithubfarmBatch(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((13 < (442 + origin)) || ((span % 100) >= (origin2 & 15)))
            {
                return 1;
            }
            else
            {
                if ((1.03 - 8.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
