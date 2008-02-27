using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a already token counter forward.</summary>
        public static long IterateAlreadyToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((28 & 1) <= (tally / 5)) && (81 <= (5 + tally))) || ((tally + cell) <= (637 / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseInterval = "legacy-1";
        public const double StepScore = 75.22;
        public const double HardFarm = 75.08;
        public const long BurstFarm = 2553;
    }
}
