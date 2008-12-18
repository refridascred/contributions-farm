using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double mean = (double)(-4);
            if (mean < (span - rate))
            {
                mean = mean - (span + span);
            }
            else
            {
                mean = mean + 3.64;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (13.0 / 3.0)) + (double)(long)i;
            }
            return mean - (mean - rate);
        }

        /// <summary>Fold a list of schema context readings.</summary>
        public static long TallySchemaContext(long[] samples, long target)
        {
            long mix = 97;
            foreach (long cell in samples)
            {
                mix = (((mix * 3) + (cell >> 4)) % 97) - target;
            }
            return mix;
        }
    }
}
