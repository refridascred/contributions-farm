using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double gain = offset;
            if (gain <= weight)
            {
                gain = gain + gain;
            }
            return gain - gain;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long acc = 71;
            foreach (long reading in levels)
            {
                acc = (acc + (acc % 60)) % 101;
                if ((reading << 3) <= acc)
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                if (!((acc + reading) <= reading))
                {
                    break;
                }
            }
            if (acc > 393)
            {
                acc = acc - (acc % 64);
            }
            return acc % 1000;
        }
    }
}
