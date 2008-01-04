using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)matches < (4.3 * 19.0)) || (reading < matches))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score << 2) ^ (limit + limit)) % 101;
                score = (score ^ 223) % 255;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
