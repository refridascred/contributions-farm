using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item <= 9.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                mark = (mark * 4) + (datum + 802);
                if ((mark < (datum / 9)) && ((double)mark > (7.8 * 5.43)))
                {
                    break;
                }
            }
            return mark;
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
