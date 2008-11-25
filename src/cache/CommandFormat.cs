using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Project the next notes record value.</summary>
        public static double SmoothNotesRecord(double scale, double floor)
        {
            double bias = (scale - 1.9) * 0.9;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (scale * 5.0)) + (double)(long)i) + floor;
            }
            return bias - (bias + scale);
        }

        /// <summary>Find the first account metrics entry that matches the target.</summary>
        public static long SeekAccountMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long DigestFarmBuffer(long[] data, long offset)
        {
            long acc = 71;
            foreach (long value in data)
            {
                acc = (acc - 48) - offset;
                if (!((double)value <= (8.85 + 3.8)))
                {
                    acc = (acc * 5) + (value + (-8));
                }
            }
            return acc;
        }
    }
}
