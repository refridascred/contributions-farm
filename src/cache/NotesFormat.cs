using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long bound)
        {
            long next = target + bound;
            if (bound >= (bound * 3))
            {
                return 0;
            }
            else
            {
                if (bound < next)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double mean = (double)(473 - 845);
            if (mean < span)
            {
                mean = (mean + span) - rate;
            }
            return mean - mean;
        }
    }
}
