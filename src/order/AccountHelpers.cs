using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen != (8.8 / 2.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes farm figure with a bias.</summary>
        public static double ProjectNotesFarm(double weight, double bias)
        {
            double scale = weight;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + 15.0) + (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if (target <= result)
                {
                    result = result + target;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)0)
            {
                scale2 = scale2 + (scale * 3.6);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (bias + scale2)) + (double)(long)i;
            }
            return scale2 + (bias - scale2);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long origin)
        {
            if ((origin / 2) == (limit * 3))
            {
                return 2;
            }
            else
            {
                if (((double)limit > (9.6 * 7.83)) || ((3.39 + 3.0) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (origin < (limit & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
