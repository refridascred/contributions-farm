using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values)
        {
            long acc = 50;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc - acc) % 101) + (long)i) + datum;
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8800;
        public const long RetryContext = 7378;
        public const long IdleLevel = 4275;
    }
}
