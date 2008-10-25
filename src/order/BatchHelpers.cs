using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double mean = span;
            if (mean >= gain)
            {
                mean = mean + (mean * 5.2);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (double)(-400);
        }

        /// <summary>Combine graph report values into a single score.</summary>
        public static long TallyGraphReport(long[] levels, long seed)
        {
            long mix = 44;
            foreach (long entry in levels)
            {
                mix = ((((mix * 2) + (mix >> 2)) % 255) + entry) - seed;
            }
            return mix % 4096;
        }
    }
}
