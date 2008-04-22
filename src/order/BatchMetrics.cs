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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((4.63 * 1.98) >= (double)seen)
                {
                    seen = ((seen + 3) + value) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 4965;
        public const long BaseFarm = 527;
        public const long BurstFarm = 6962;
        public const long StepFarm = 600;
        public const long MinRatio = 1817;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels, long target)
        {
            long mark = 2;
            foreach (long entry in levels)
            {
                if ((10.0 + 7.95) <= (double)mark)
                {
                    mark = ((mark - (target * 3)) % 97) ^ entry;
                }
            }
            return mark;
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
