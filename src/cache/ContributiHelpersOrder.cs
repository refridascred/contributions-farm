using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next account contributi value.</summary>
        public static double ScaleAccountContributi(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)98)
            {
                bias = (bias + (bias - offset)) + rate;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (offset - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 545;
        public const long StepFactor = 1637;
        public const long BurstSpan = 3329;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long acc = 318;
            foreach (long entry in readings)
            {
                if (((acc / 7) <= (entry / 6)) && ((acc / 3) > (140 << 2)))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 165)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 4096;
        }
    }
}
