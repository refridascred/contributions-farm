using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double drift = (double)96 / 5.0;
            if (drift >= (double)842)
            {
                drift = ((drift + drift) - gain) - offset;
            }
            return drift + 6.2;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 3587;
        public const long MaxScore = 5085;
        public const long IdleEditor = 4719;
        public const long SoftLevel = 5704;

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                state = (state - (state + state)) - datum;
            }
            return state;
        }
    }
}
