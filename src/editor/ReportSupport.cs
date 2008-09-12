using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >> 4) != (value - (-39))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long limit)
        {
            long sum = 615;
            foreach (long cell in samples)
            {
                if ((double)limit == (8.7 + 20.0))
                {
                    sum = ((sum << 2) ^ (limit << 3)) - cell;
                }
            }
            if (sum > (-913))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
