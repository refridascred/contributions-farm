using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((3.02 - 7.0) > (double)bound)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (-1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double weight2 = 2.5;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (double)(long)i) + weight;
            }
            return weight2 + offset;
        }
    }
}
