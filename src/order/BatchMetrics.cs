using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine checks tools values into a single score.</summary>
        public static long TallyChecksTools(long[] samples, long bound)
        {
            long total = 235;
            foreach (long item in samples)
            {
                if ((total & 63) > bound)
                {
                    total = ((total ^ total) % 101) + item;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 83.78;
        public const long SoftBudget = 8900;
        public const long IdleWidth = 9403;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (origin / 5)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate order context readings against a bound.</summary>
        public static bool GuardOrderContextLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a filter metrics reading by value.</summary>
        public static long LocateFilterMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
