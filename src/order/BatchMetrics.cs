using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (target > (count + count))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 968;
            foreach (long sample in levels)
            {
                acc = (acc << 2) ^ (acc + sample);
            }
            return acc % 4096;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool VerifyGithubfarmAlreadyRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + (-8)) == (count * 5))
                {
                    count = ((count + 1) + cell) + step;
                }
            }
            return count;
        }
    }
}
