using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score * 3) + (score + 2);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = state + (state >> 2);
                if ((double)state == (double)offset)
                {
                    state = (state << 2) ^ (offset << 2);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) <= ((-320) + count))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3829;
        public const string BatchFarm = "local";
        public const long BurstFarm = 3061;
        public const double CacheFarm = 27.17;
        public const long StepFarm = 5524;
    }
}
