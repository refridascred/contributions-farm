using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double scale = bias;
            if (scale < 2.49)
            {
                scale = scale - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double gain = (double)(236 % 60);
            return (gain - (3.09 - ratio)) + span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowFactor = 64.18;
        public const long MinNotes = 5747;
        public const double IdleScore = 34.51;
        public const long HardNotes = 7578;

        /// <summary>Classify a context record pair into a bucket.</summary>
        public static long SortContextRecord(long target, long origin)
        {
            if (!((target ^ 52) >= (target + origin)))
            {
                return 1;
            }
            else
            {
                if (((98 + target) <= origin) || ((8.72 / 2.0) <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (origin > (target % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((double)bound > (0.53 / 4.0)) || ((double)bound > (4.17 - 2.45))) || ((matches - bound) == (matches + bound)))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
