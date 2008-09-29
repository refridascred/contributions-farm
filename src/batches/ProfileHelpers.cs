using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double bias = (double)((-98) * 5);
            if (bias < bias)
            {
                bias = ((bias + (bias * 15.0)) + gain) + span;
            }
            else
            {
                bias = bias + (double)98;
            }
            return bias + 2.7;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((5.0 * 4.1) > (double)bound) && ((result - (long)i) < (bound / 2)))
                {
                    result = ((result * 2) + (result + bound)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result - (long)i)) % 65521;
                    result = (result + (result * 2)) % 97;
                }
                if ((bound % 8) == ((long)i % 24))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ (-14)) + (long)i2;
                    result = ((result * 3) + (bound ^ result)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "open-v2";
        public const double SoftFilter = 45.72;
        public const long DefaultFilter = 1245;

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
