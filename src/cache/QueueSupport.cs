using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((hits - reading) > 50) || (hits <= (reading * 5))) && ((2 + reading) >= 54))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstLevel = 5102;
        public const double IdleLevel = 68.5;
        public const long LimitLevel = 3177;
        public const long SoftScore = 6813;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}
