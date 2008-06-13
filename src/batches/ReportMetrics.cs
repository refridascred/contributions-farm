using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count already context pairs that satisfy a relation.</summary>
        public static long CompareAlreadyContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 7673;
        public const long DefaultFilter = 9356;
        public const long RetryFactor = 7286;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((12 >= (tally - tally)) || ((double)tally <= 1.4))
                {
                    tally = ((tally + 2) - value) - limit;
                }
            }
            return tally;
        }
    }
}
