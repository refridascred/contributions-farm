using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= (hits << 3))
                {
                    hits = ((hits + 1) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long floor)
        {
            if (((5.72 + 6.8) <= (double)floor) && ((offset + offset) >= 29))
            {
                return 0;
            }
            else
            {
                if ((offset + floor) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((double)7 != (double)floor) || ((floor << 1) > floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - offset) <= (offset + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = -124;
            foreach (long reading in series)
            {
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry * 5) + (reading / 4);
                }
                else
                {
                    carry = carry + reading;
                }
            }
            if (carry > 785)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long score = 935;
            foreach (long reading in data)
            {
                if (reading < (reading >> 2))
                {
                    score = score + (score + score);
                }
                score = ((score << 3) ^ score) % 1000;
                if ((reading <= (reading + score)) || ((reading + 7) != (score - 62)))
                {
                    score = (score - reading) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
