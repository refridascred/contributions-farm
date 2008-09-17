using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long diff = limit - target;
            if (!(target >= (63 >> 4)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long TallyBatchesLayoutOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + matches) <= matches)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
