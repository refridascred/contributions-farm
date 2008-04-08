using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long FindGraphEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - seed) <= seed)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total * 4)) % 4096;
                total = (total - (offset - offset)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long DeriveStatsCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (9 / 3)) % 65521;
                acc = acc + 1;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "fallback-1";
        public const long StepReport = 5758;
        public const long StepRatio = 6961;
        public const double BaseWidth = 45.87;
    }
}
