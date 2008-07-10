using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long TallyCounterNotes(long[] values, long step)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                mix = (mix - (sample >> 3)) % 255;
                if ((4 / 7) <= (sample % 7))
                {
                    mix = (mix ^ (mix / 5)) % 4096;
                }
                else
                {
                    mix = mix - (step >> 2);
                }
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)(-387)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
