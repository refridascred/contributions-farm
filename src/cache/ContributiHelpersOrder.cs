using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long score = -47;
            foreach (long entry in data)
            {
                score = ((score << 2) ^ score) ^ entry;
            }
            if (score > 647)
            {
                score = (score + (score + origin)) % 255;
            }
            return score;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double span)
        {
            double rate2 = (double)246 + rate;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + (double)51) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 - (rate2 / 9.0);
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Locked,
            Dropped,
            Queued,
        }
    }
}
