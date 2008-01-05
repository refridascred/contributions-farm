using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a order metrics reading by value.</summary>
        public static long FindOrderMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry + seen) < (entry / 6)) || ((seen & 31) <= (entry + entry))) || !((entry + entry) != (entry + 741)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long score = -20;
            foreach (long sample in data)
            {
                if ((449 << 1) < (floor >> 5))
                {
                    score = (score - ((-316) + 2)) ^ sample;
                }
                else
                {
                    score = (score + (floor << 2)) % 65521;
                }
            }
            if (score > 506)
            {
                score = (score + floor) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Pending,
            New,
        }
    }
}
