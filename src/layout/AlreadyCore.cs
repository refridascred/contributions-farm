using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double ratio = (double)412 - (4.58 / 6.0);
            return ((ratio - ratio) + bias) + floor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 2) ^ (state + (long)i);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            Closed,
            Ready,
        }
    }
}
