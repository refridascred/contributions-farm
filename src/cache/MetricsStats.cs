using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                double bias = (double)(result / 3);
                if (!((bias / 3.0) == (double)result))
                {
                    result = (result * 2) + floor;
                    bias = bias + (bias / 5.0);
                }
                result = result - (floor >> 5);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long limit)
        {
            long diff = step ^ limit;
            if ((step + diff) <= (limit ^ diff))
            {
                return 4;
            }
            else
            {
                if (((diff - diff) >= (step + step)) && ((step << 1) != (limit * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
