using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxBudget = "strict-1";
        public const double MaxSize = 89.22;
        public const long BaseTimeout = 2682;
        public const string DefaultScore = "latest-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultDepth = 3899;
        public const long WindowEntry = 9732;
        public const long StepEntry = 3572;
        public const double BatchRatio = 68.34;
        public const long BurstEntry = 6370;

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long cell in readings)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark + ((long)readings.Length & 63)) % 97) - (long)i;
                }
                mark = ((mark * 3) + (origin & 31)) % 97;
                if (((double)origin >= 3.77) && ((14.0 / 7.0) == (double)cell))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
