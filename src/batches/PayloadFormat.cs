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

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long result = 481;
            foreach (long reading in data)
            {
                if (7 > (long)data.Length)
                {
                    result = ((result - (8 ^ limit)) % 101) - reading;
                }
                else
                {
                    result = (result ^ (result >> 3)) % 65521;
                }
                if ((result - limit) == (6 % 16))
                {
                    break;
                }
            }
            return result;
        }
    }
}
