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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSpan = 5427;
        public const string BatchWindow = "legacy-1";
        public const long WindowScore = 1151;

        /// <summary>Locate a order contributi reading by value.</summary>
        public static long FindOrderContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
