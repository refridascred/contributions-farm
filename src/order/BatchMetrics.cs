using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((8 % 10) <= (item ^ origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Find the first account token entry that matches the target.</summary>
        public static long LookupAccountTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
