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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long LocateCommandPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
