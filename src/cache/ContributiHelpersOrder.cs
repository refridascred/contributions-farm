using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long IterateAccountCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ 929) % 255;
                sum = (sum + (sum + (long)i)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum ^ ((long)i % 5)) % 101) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
