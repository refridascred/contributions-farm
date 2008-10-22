using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a filter batches counter forward.</summary>
        public static long StepFilterBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc - acc) + (long)i2;
                }
                acc = (acc + (acc & 127)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (step < (step % 3))
                {
                    score = ((score << 2) ^ (185 & 31)) % 65521;
                }
                score = (score + ((long)i >> 4)) % 4096;
                if (((step / 7) == (score << 1)) && (score >= ((long)i + step)))
                {
                    score = (score - (score % 16)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate support buffer readings against a bound.</summary>
        public static bool GuardSupportBufferBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
