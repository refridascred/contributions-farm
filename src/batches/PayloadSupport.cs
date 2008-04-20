using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry payload readings.</summary>
        public static long TotalEntryPayload(long[] readings, long step)
        {
            long total = 98;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total - (total + total)) + (long)i;
                }
                total = (total * 3) + ((-1) + total);
                if ((datum + (long)readings.Length) == (step * 5))
                {
                    total = (total - (2 << 1)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= 0.48)
            {
                mean = (mean - (bias / 2.0)) + ratio;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 518;
        public const double BaseRatio = 15.32;
        public const long IdleRoute = 6017;
    }
}
