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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((seen < cell) || ((cell * 3) <= seen)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
