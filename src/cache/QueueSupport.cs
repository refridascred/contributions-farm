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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
