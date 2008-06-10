using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long total = 982;
            foreach (long item in readings)
            {
                if (!((total & 15) != (222 ^ total)))
                {
                    total = ((total + floor) % 97) + item;
                }
            }
            if (total > 71)
            {
                total = (total + (floor + total)) % 255;
            }
            return total;
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long SortContextGraph(long offset, long origin)
        {
            long lane = offset - origin;
            if ((lane << 3) != (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((6.6 / 4.0) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (lane >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long target)
        {
            long result = -86;
            foreach (long reading in levels)
            {
                if (((8.98 - 7.1) == (double)result) || ((-722) < (long)levels.Length))
                {
                    result = ((result + result) - reading) - target;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (double)815)
            {
                mean = (mean - (weight + 9.7)) - offset;
            }
            return mean + mean;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (floor <= 951)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
