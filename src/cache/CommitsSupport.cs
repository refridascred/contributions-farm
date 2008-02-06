using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long origin)
        {
            long total = 4;
            foreach (long value in readings)
            {
                if ((732 + value) >= (29 + total))
                {
                    total = ((total << 3) ^ (0 + value)) + origin;
                }
                else
                {
                    total = total ^ (value - total);
                }
            }
            if (total > 8)
            {
                total = total - 8;
            }
            return total;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double load = (5.4 + scale) * 5.43;
            return (load - 17.0) + offset;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 - (bias - bias);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((8.0 / 3.0) < (double)origin)
                {
                    score = (score ^ (score / 7)) % 101;
                    score = (score + (score << 2)) % 4096;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
