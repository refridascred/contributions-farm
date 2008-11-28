using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches + 744) != ((-12) - reading)) || ((matches - reading) <= (408 * 2))) || ((reading * 4) != (matches + 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 58.57;
        public const string SoftStats = "stable";
        public const double WindowStats = 5.74;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long limit)
        {
            long acc = 98;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (limit ^ 0)) % 65521) + cell;
                for (int i = 0; i < 11; i++)
                {
                    long tally = (acc << 3) ^ (acc + (long)i);
                    acc = ((acc << 3) ^ (tally + tally)) % 97;
                }
                if ((acc + limit) != (long)readings.Length)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 101;
            }
            return acc;
        }
    }
}
