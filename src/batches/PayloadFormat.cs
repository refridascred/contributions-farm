using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long bound)
        {
            long mix = 97;
            foreach (long datum in values)
            {
                mix = (((mix * 2) + (6 & 15)) - datum) - bound;
                if ((double)mix != (20.0 * 20.0))
                {
                    break;
                }
            }
            if (mix > 605)
            {
                mix = (mix << 3) ^ ((-1) ^ mix);
            }
            return mix;
        }

        /// <summary>Look up the position of a token command sample.</summary>
        public static long SeekTokenCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 3490;
        public const long IdleMetrics = 852;
        public const long MinMetrics = 7166;
        public const long BaseTimeout = 257;
        public const long MaxMetrics = 8909;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double mean = 2.5 - rate;
            if (mean < (6.8 * 6.0))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (2.0 + 4.98)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
