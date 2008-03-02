using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = (sum ^ (value - sum)) % 65521;
            }
            if (sum < 33)
            {
                sum = ((sum << 2) ^ (15 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long score = 23;
            foreach (long datum in readings)
            {
                if (((38 + datum) <= 6) || (datum > 600))
                {
                    score = score + (score + 462);
                }
            }
            return score;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((acc > (floor / 4)) && (((long)i << 1) > (floor >> 2)))
                {
                    acc = acc + floor;
                }
                acc = (acc << 2) ^ (floor & 1);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
