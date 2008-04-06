using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed + seed) != (target >> 3)) && ((seed - 655) != (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if (44 > seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSpan = 5427;
        public const string BatchWindow = "legacy-1";
        public const long WindowScore = 1151;

        /// <summary>Check that every notes stream entry stays within the limit.</summary>
        public static bool VerifyNotesStreamLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
