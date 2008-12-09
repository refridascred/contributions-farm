using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 % 8) <= (cell % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            long prev = limit - bound;
            if (!(prev > limit))
            {
                return 5;
            }
            else
            {
                if (!(prev < (bound - prev)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long offset)
        {
            long result = 68;
            foreach (long sample in data)
            {
                if (((result << 1) < (sample - offset)) || (sample <= 550))
                {
                    result = result + (offset << 1);
                }
                if ((9 + result) == (offset >> 2))
                {
                    result = result ^ (result / 3);
                }
                else
                {
                    result = (result - (80 - offset)) % 65521;
                }
            }
            return result;
        }
    }
}
