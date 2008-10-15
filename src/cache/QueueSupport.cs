using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of order notes readings.</summary>
        public static long DigestOrderNotes(long[] data, long floor)
        {
            long mix = -217;
            foreach (long cell in data)
            {
                if (!((9.0 - 3.79) != (double)cell))
                {
                    mix = ((mix << 3) ^ (floor % 97)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Scale a cluster session figure with a bias.</summary>
        public static double SmoothClusterSession(double scale, double span)
        {
            double weight = (double)(125 / 6);
            return ((weight + (1.78 / 4.0)) + scale) + span;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (long)readings.Length)
                {
                    sum = ((sum * 4) + seed) % 101;
                    sum = (sum + seed) % 4096;
                }
                sum = ((sum * 4) + entry) % 65521;
            }
            if (sum < 664)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
