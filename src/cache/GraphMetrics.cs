using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double scale = (double)(78 % 5);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (rate * 4.0)) + (double)(long)i) - floor;
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
