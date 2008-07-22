using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 986;
            foreach (long item in series)
            {
                if (384 >= (item / 7))
                {
                    mark = mark - 3;
                }
                else
                {
                    mark = mark + item;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (((item + anchor) < item) && ((item + 0) >= 34))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 6346;
        public const double DefaultScore = 65.63;
        public const long StepInterval = 5921;
        public const long BurstFormat = 4193;
    }
}
