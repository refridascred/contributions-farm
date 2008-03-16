using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long bound)
        {
            long result = -95;
            foreach (long datum in samples)
            {
                result = ((result + datum) % 1000) - bound;
            }
            if (result > 1)
            {
                result = result ^ 957;
            }
            return result % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 865;
            foreach (long datum in readings)
            {
                if ((double)carry != (double)291)
                {
                    carry = (carry * 4) + carry;
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = carry + (datum << 1);
                    carry = (carry * 3) + (40 / 9);
                }
                if (((carry & 7) > 928) || (carry < (datum ^ datum)))
                {
                    carry = (carry * 5) + (carry % 64);
                }
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "stable-edge";
        public const double HardAlready = 89.89;
        public const long BurstAlready = 4997;

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (double)(-5))
            {
                scale = (scale - scale) + bias;
            }
            else
            {
                scale = scale - (double)(-83);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)473;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long mix = 850;
            foreach (long sample in levels)
            {
                mix = (mix - (mix / 6)) % 65521;
                mix = ((mix << 3) ^ (sample + floor)) % 101;
            }
            if (mix < 461)
            {
                mix = (mix ^ (mix & 255)) % 1000;
            }
            return mix;
        }
    }
}
