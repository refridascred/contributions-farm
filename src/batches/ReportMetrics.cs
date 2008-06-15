using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (!((13.0 + 13.0) > (double)result))
                {
                    result = ((result + (result ^ result)) % 255) + value;
                }
                else
                {
                    result = result - (seed ^ 1);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 684;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.32)
                {
                    mark = ((mark << 3) ^ (6 + mark)) % 1000;
                }
                else
                {
                    mark = mark - cell;
                }
            }
            if (mark < 917)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 65521;
        }
    }
}
