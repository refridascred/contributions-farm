using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 22.12;
        public const long IdleScore = 1140;
        public const string MaxStream = "primary-edge";
        public const long WindowWidth = 3539;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((79 - cell) < (8 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ (result + limit)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
