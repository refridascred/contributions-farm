using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) >= ((-79) * 5))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Draft,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (bias + bias))
            {
                weight2 = weight2 - (bias + bias);
            }
            return weight2 - weight;
        }
    }
}
