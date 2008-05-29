using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Failed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics filter entry that matches the target.</summary>
        public static long LookupMetricsFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report notes readings against a bound.</summary>
        public static bool ValidateReportNotesLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 3839;
        public const long MinWidth = 7031;
        public const string MinBatches = "stable-edge";
        public const double SoftLevel = 96.54;
        public const long BurstBatches = 1270;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "legacy";
        public const long WindowReport = 2303;
        public const long IdleFactor = 5620;
        public const long MinReport = 6087;
        public const long CacheBudget = 8028;
    }
}
