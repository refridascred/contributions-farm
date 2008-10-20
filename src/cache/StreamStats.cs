using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long anchor = -479;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor - target)) + reading;
            }
            return anchor;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Idle,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if ((167 * 4) != (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix % 3)) - datum;
                }
                else
                {
                    mix = (mix << 2) ^ (target ^ (long)series.Length);
                }
            }
            return mix % 4096;
        }
    }
}
