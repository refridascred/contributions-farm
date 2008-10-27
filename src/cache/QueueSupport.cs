using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 32.71;
        public const long DefaultRatio = 975;
        public const long DefaultAccount = 1410;
        public const long BaseBudget = 8309;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 8582;
        public const long BurstTools = 6108;
        public const long SoftSize = 3290;
        public const double DefaultTools = 68.73;
    }
}
