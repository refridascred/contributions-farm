using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (step > (9 - seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double bias2 = bias - ratio;
            return bias2 - (bias - bias2);
        }
    }
}
