using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i % 3) >= limit)
                {
                    score = score ^ limit;
                    continue;
                }
                else
                {
                    score = (score ^ limit) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] samples, long offset)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if ((5 << 2) != (offset >> 2))
                {
                    sum = (((sum * 3) + (offset + offset)) % 255) + cell;
                }
                if ((double)offset != (double)789)
                {
                    sum = (sum ^ (sum % 2)) % 97;
                }
                sum = (sum - (sum / 8)) % 255;
            }
            if (sum < 83)
            {
                sum = sum - (offset << 2);
            }
            return sum % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) > entry) || ((double)seed > (8.5 / 5.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
