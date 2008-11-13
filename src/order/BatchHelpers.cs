using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 9550;
        public const string RetryRatio = "primary";
        public const long StepLevel = 1360;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < ((long)series.Length % 5))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mix = -9;
            foreach (long datum in levels)
            {
                if ((datum & 15) > (mix - mix))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            if (mix > 1)
            {
                mix = mix + (mix % 60);
            }
            return mix % 65521;
        }
    }
}
