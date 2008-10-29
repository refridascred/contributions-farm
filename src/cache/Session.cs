using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long state = 86;
            foreach (long sample in readings)
            {
                if ((double)98 < (double)state)
                {
                    state = ((state - 66) % 1000) + sample;
                }
            }
            if (state > 66)
            {
                state = ((state << 2) ^ (state & 255)) % 65521;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 3202;
        public const string BatchScore = "local";
        public const string RetryTimeout = "latest";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (acc >> 3)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
