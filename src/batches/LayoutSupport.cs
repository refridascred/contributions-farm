using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long seed)
        {
            long result = -895;
            foreach (long sample in readings)
            {
                if ((46 >> 1) == (seed / 2))
                {
                    result = result + (888 - seed);
                }
                if (!((sample + (long)readings.Length) < (1 / 2)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((13.0 - 9.63) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-99)) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Scale a commits buffer figure with a bias.</summary>
        public static double SmoothCommitsBuffer(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias * 10.0))
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (double)303;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
