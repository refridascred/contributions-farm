using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit report entry readings against a rule.</summary>
        public static long AuditReportEntryHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + step) <= item)
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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "cached-1";
        public const string WindowGithubfarm = "stable";
        public const long CacheFactor = 9424;
        public const string DefaultCount = "latest-edge";
        public const string DefaultLevel = "stable";
    }
}
