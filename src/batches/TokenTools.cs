using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > ratio)
            {
                bias2 = (bias2 - bias2) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 12.0) - (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long limit)
        {
            long step = target ^ limit;
            if ((limit < step) || ((limit + step) > 0))
            {
                return 6;
            }
            else
            {
                if (step <= (target - step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Pending,
            Stale,
            Failed,
            Closed,
        }
    }
}
