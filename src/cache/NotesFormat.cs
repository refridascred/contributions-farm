using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1746;
        public const double BurstTimeout = 77.14;
        public const long MaxFactor = 3995;
        public const long StepSpan = 1939;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 3) ^ sum) % 101;
                if ((double)(long)i >= (15.0 + 5.37))
                {
                    sum = (sum ^ (847 - limit)) % 255;
                    sum = (sum << 3) ^ limit;
                }
                else
                {
                    sum = (sum + limit) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (seed + state)) % 1000;
                state = ((state * 2) + (seed + seed)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
