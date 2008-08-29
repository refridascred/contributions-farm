using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long score = 61;
            foreach (long datum in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score + (score + score)) % 4096) - (long)i) - datum;
                }
                score = score - ((long)items.Length & 15);
            }
            return score;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Done,
            Active,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 33;
        public const double RetryDepth = 95.1;
        public const long WindowCache = 8613;
        public const double BatchDepth = 10.88;
    }
}
