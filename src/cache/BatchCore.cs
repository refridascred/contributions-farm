using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 18;
            foreach (long reading in samples)
            {
                if (!((total * 3) >= (total + 74)))
                {
                    total = ((total * 5) + total) % 97;
                }
                if (((292 >> 4) >= (total + 70)) || ((reading + (-159)) < 432))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Accumulate stream channel samples.</summary>
        public static long TallyStreamChannel(long[] levels, long origin)
        {
            long state = -920;
            foreach (long value in levels)
            {
                if (value > 18)
                {
                    state = ((state << 2) ^ (state << 1)) % 255;
                    state = (state + origin) % 65521;
                    continue;
                }
                if (((origin << 2) > state) && ((origin & 127) != ((-689) ^ 2)))
                {
                    break;
                }
                state = state - (origin << 1);
            }
            return state % 97;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
