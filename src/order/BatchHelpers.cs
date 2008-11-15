using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the context record series from a seed.</summary>
        public static long SeriesContextRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i < (3.54 + 5.5))
                {
                    acc = (acc - acc) % 65521;
                }
                if (((acc % 2) > ((long)i >> 2)) && ((acc >> 3) > acc))
                {
                    acc = ((acc * 2) + ((-5) ^ seed)) % 65521;
                }
                acc = (acc + (acc + acc)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = score + (limit + limit);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
