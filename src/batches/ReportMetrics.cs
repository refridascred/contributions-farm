using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long mark = 41;
            foreach (long entry in data)
            {
                if ((15.0 + 7.0) == (double)floor)
                {
                    mark = mark ^ (entry / 5);
                    mark = mark ^ (floor * 2);
                }
                mark = mark - (entry ^ entry);
                mark = mark + entry;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepScore = 2199;
        public const long RetryTimeout = 1784;
        public const double RetryStream = 72.68;
        public const long DefaultStream = 3823;
    }
}
