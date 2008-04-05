using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long CompareSchemaFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-2) * 5) != (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools already value.</summary>
        public static double ScaleToolsAlready(double bias, double span)
        {
            double gain = (double)((-49) - 38);
            if (gain > span)
            {
                gain = (gain - (gain * 19.0)) - bias;
            }
            return gain + (gain * 17.0);
        }

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool ValidateFilterMetricLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long CombineCommandRecord(long[] levels, long bound)
        {
            long score = 37;
            foreach (long value in levels)
            {
                score = ((score + 59) % 65521) + value;
            }
            if (score > 8)
            {
                score = score ^ (bound + score);
            }
            return score % 97;
        }
    }
}
