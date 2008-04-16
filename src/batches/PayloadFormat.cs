using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream farm values into a single score.</summary>
        public static long FoldStreamFarm(long[] values)
        {
            long result = 225;
            foreach (long entry in values)
            {
                result = ((result * 3) + (result ^ entry)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell & 3) > (long)samples.Length) || !((7.72 + 15.0) != (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            long offset = target ^ floor;
            if ((offset << 2) >= (floor % 24))
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (offset - floor)) && ((8.1 * 4.0) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((752 & 1) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine window stats values into a single score.</summary>
        public static long TallyWindowStats(long[] series)
        {
            long carry = -3;
            foreach (long value in series)
            {
                if ((double)value <= (double)carry)
                {
                    carry = (carry ^ (value << 2)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
