using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double mean = (double)0 - ratio;
            if (mean < (double)59)
            {
                mean = mean - (offset + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset / 2.0)) + (double)(long)i;
            }
            return mean - (3.8 / 4.0);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
