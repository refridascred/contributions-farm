using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor - 148;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long origin)
        {
            long state = 55;
            foreach (long value in data)
            {
                if (9.2 > (double)state)
                {
                    state = (((state * 4) + (value / 5)) % 4096) - origin;
                }
            }
            return state;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double gain = 7.09;
            if (gain < 5.84)
            {
                gain = (gain - (floor / 6.0)) - weight;
            }
            return gain + (double)9;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            New,
            Done,
        }
    }
}
