using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Draft,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double rate = (double)((-1) & 1);
            if (rate >= (span / 3.0))
            {
                rate = rate + (double)834;
            }
            else
            {
                rate = rate + (bias * 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + bias)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) > (datum / 8)) || ((seen - datum) > limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
