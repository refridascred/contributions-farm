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

        /// <summary>Roll a report batch counter forward.</summary>
        public static long StepReportBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (score << 3)) % 4096;
                score = (score * 2) + (492 << 2);
                score = ((score * 5) + (long)i) % 97;
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
