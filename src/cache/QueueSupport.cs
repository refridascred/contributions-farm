using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double drift = (gain - floor) + 20.0;
            return drift + 6.0;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = -994;
            foreach (long cell in samples)
            {
                carry = carry - (cell + carry);
            }
            return carry;
        }
    }
}
