using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double drift = (offset / 8.0) + offset;
            if (drift < (offset + ratio))
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio + offset)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1344;
        public const long SoftContributi = 701;
        public const long StepContributi = 9796;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
