using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long seed)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (((value & 15) >= total) || ((seed & 3) != (value % 64)))
                {
                    total = ((total << 3) ^ (value + seed)) % 1000;
                    total = ((total << 3) ^ seed) % 97;
                }
                total = (total * 2) + value;
            }
            return total % 97;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((453 + origin) >= (cell - seen)) && ((origin - origin) < origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long target, long floor)
        {
            if ((target ^ floor) > (floor + 587))
            {
                return 5;
            }
            else
            {
                if ((target + target) < (6 - target))
                {
                    return 8;
                }
                else
                {
                    if ((target - floor) > (81 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = -52;
            foreach (long entry in values)
            {
                total = ((total << 2) ^ (total % 12)) % 101;
                total = (total << 2) ^ (entry - total);
                total = ((total << 2) ^ 394) % 101;
            }
            return total;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + 124) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
