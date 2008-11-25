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

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double rate = (double)1 / 4.0;
            if (rate < weight)
            {
                rate = (rate - 10.0) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (8.8 + weight)) + (double)(long)i;
            }
            return rate + weight;
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
