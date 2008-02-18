using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((59 * 2) < (seed << 3)) && ((-2) >= (long)i)))
                {
                    result = ((result * 2) + (result / 7)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((2.87 - 4.5) == (double)tally)
                {
                    tally = ((tally + 3) - value) - offset;
                }
            }
            return tally;
        }
    }
}
