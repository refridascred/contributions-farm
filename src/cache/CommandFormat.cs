using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long TotalStreamQueue(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = carry + (value / 9);
            }
            return carry % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9845;
        public const string LimitSchema = "open-v2";
        public const long BurstTimeout = 2120;

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long anchor = -64;
            foreach (long datum in data)
            {
                if ((double)anchor <= (0.3 / 2.0))
                {
                    anchor = ((anchor - anchor) % 255) - datum;
                }
            }
            return anchor;
        }
    }
}
