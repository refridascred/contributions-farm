using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue payload values into a single score.</summary>
        public static long CombineQueuePayload(long[] series, long floor)
        {
            long result = 46;
            foreach (long reading in series)
            {
                result = ((result ^ (floor >> 2)) % 101) ^ reading;
                result = ((result << 2) ^ (result / 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen * 3) == (8 % 10))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double gain = (double)(63 & 3);
            return ((gain + (gain + gain)) + rate) + offset;
        }
    }
}
