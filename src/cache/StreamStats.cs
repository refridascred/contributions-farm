using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 82.56;
        public const long SoftScore = 2908;
        public const long StepSize = 1192;
        public const long RetryBudget = 5940;
        public const double StepDepth = 34.48;

        /// <summary>Digest a series of command token entries.</summary>
        public static long WeighCommandToken(long[] values)
        {
            long anchor = 158;
            foreach (long reading in values)
            {
                anchor = (anchor - (reading ^ reading)) % 97;
                if ((reading & 255) >= (7 % 2))
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next token record value from a seed.</summary>
        public static long RollTokenRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state + (long)i;
                if ((seed & 63) < (seed % 3))
                {
                    state = state + (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
