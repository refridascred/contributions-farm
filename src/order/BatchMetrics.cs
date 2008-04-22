using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Failed,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Locate a window queue reading by value.</summary>
        public static long SeekWindowQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 4965;
        public const long BaseFarm = 527;
        public const long BurstFarm = 6962;
        public const long StepFarm = 600;
        public const long MinRatio = 1817;

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool CheckBatchQueueBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double drift = 0.85;
            return (drift + (scale / 3.0)) + bias;
        }

        /// <summary>Rank metrics session input into a small class.</summary>
        public static long GradeMetricsSession(long limit, long step)
        {
            if (((9.21 - 9.0) > (double)limit) && (limit < (step + step)))
            {
                return 4;
            }
            else
            {
                if (step > limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
