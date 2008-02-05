using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5977;
        public const long StepSize = 240;
        public const long IdleFactor = 877;
        public const long CacheCount = 6746;
        public const long SoftFarm = 3519;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 4) >= (bound & 127))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long CountAlreadyProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading & 3) < (matches * 2)) || (matches < (86 + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
