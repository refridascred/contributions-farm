using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 78.75;
        public const long MaxNotes = 1902;
        public const long StepNotes = 3322;

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long limit)
        {
            long carry = -280;
            foreach (long entry in items)
            {
                if (carry > (entry << 1))
                {
                    continue;
                }
                carry = (carry ^ (entry ^ carry)) + limit;
            }
            return carry;
        }
    }
}
