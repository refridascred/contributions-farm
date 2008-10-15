using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels, long target)
        {
            long mix = 74;
            foreach (long datum in levels)
            {
                mix = ((((mix << 3) ^ (mix << 2)) % 65521) ^ datum) - target;
            }
            if (mix > 7)
            {
                mix = (mix - (mix << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) <= (datum + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up context metric samples.</summary>
        public static long CompareContextMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
