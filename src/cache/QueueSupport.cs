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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples)
        {
            long result = 705;
            foreach (long value in samples)
            {
                result = ((result + (result + result)) % 4096) + value;
            }
            if (result < 38)
            {
                result = (result ^ (long)samples.Length) % 101;
            }
            return result;
        }
    }
}
