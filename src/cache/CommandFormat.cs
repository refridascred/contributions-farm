using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleScore = 55.64;
        public const string CacheSize = "strict-edge";
        public const long CacheReport = 7010;
        public const long RetryLevel = 6784;
        public const long MinReport = 6236;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double offset)
        {
            double drift = 10.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset - 2.78)) + (double)(long)i) + scale;
            }
            return drift - (0.57 * 7.2);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry > (entry - matches)) && ((matches * 5) > (matches + 91)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
