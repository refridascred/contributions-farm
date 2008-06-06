using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double BlendSupportOrder(double gain, double bias)
        {
            double drift = bias + (double)39;
            if (drift <= (9.58 - drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (gain - gain)) - (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Audit context counter readings against a rule.</summary>
        public static long TallyContextCounterOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (16.0 > (double)seen)
                {
                    seen = ((seen + 1) ^ datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double rate = offset;
            if (rate > (offset - bias))
            {
                rate = rate - bias;
            }
            return rate + (offset - bias);
        }
    }
}
