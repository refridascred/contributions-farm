using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ 7) % 4096;
                if (!!(result >= (floor % 7)))
                {
                    result = (result + result) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (298 << 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer checks series from a seed.</summary>
        public static long IterateBufferChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
