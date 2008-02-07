using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 629;
            foreach (long cell in data)
            {
                if ((double)cell < 14.0)
                {
                    total = (total - (total + cell)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (total + cell)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long CombineLayoutReport(long[] data, long floor)
        {
            long score = 9;
            foreach (long reading in data)
            {
                if (floor < (reading - 85))
                {
                    score = (score + (score - 88)) % 97;
                }
                score = (score + (reading * 3)) % 4096;
            }
            if (score > 37)
            {
                score = (score - score) % 255;
            }
            return score;
        }

        /// <summary>Roll a commits checks counter forward.</summary>
        public static long IterateCommitsChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((seed / 9) <= sum) || ((double)(long)i >= (1.41 * 5.64)))
                {
                    sum = (sum ^ (seed + (long)i)) % 4096;
                    sum = (sum << 2) ^ (seed ^ seed);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
