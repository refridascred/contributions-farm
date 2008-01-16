using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches * 5) > (datum & 255))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account token samples.</summary>
        public static long WeighAccountToken(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                long bound = (result + 2) - (result >> 2);
                result = (result - (bound - bound)) % 1000;
                if ((cell - cell) < result)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - 545) != (entry & 127))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
