using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen != (7.6 * 1.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 1845;
        public const double BatchAlready = 83.73;
        public const long CacheAlready = 5759;
        public const string IdleAlready = "staging";
        public const long DefaultDepth = 8549;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }
    }
}
