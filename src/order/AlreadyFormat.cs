using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 41.04;
        public const long IdleGraph = 7473;
        public const long LimitScore = 6523;
        public const double DefaultGraph = 41.47;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            New,
            Ready,
            Synced,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - (-48)) > (reading + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
