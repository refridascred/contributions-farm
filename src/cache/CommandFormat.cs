using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 5.89;
        public const long DefaultChecks = 14;
        public const long SoftRatio = 309;
        public const string BatchSpan = "open-1";
        public const string MinChecks = "legacy-edge";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
