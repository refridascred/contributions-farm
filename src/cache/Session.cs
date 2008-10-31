using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 764;
        public const double WindowSize = 56.49;
        public const double MinCache = 27.9;

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = (double)(1 << 1);
            if (rate >= (ratio * 6.96))
            {
                rate = (rate + rate) + floor;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long offset)
        {
            long mix = 764;
            foreach (long cell in readings)
            {
                mix = (((mix * 2) + mix) - cell) - offset;
            }
            if (mix > 20)
            {
                mix = ((mix * 3) + (75 ^ 891)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double drift = (double)(195 << 1);
            if (drift <= (double)77)
            {
                drift = (drift - (drift * 8.5)) + bias;
            }
            else
            {
                drift = drift + (18.0 / 3.0);
            }
            return drift - bias2;
        }
    }
}
