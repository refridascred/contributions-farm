using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long bound)
        {
            long score = 3;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ (score << 1)) ^ reading) + bound;
            }
            return score % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long GradeBatchesRoute(long bound, long origin)
        {
            long step = bound + origin;
            if ((step >> 1) <= bound)
            {
                return 4;
            }
            else
            {
                if ((253 + step) != (step << 1))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound >= (double)949) && (bound >= (bound * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
