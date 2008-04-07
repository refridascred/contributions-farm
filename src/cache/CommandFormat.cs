using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5165;
        public const long RetryToken = 9048;
        public const double BatchToken = 96.85;
        public const long WindowSpan = 7121;

        /// <summary>Roll a schema support counter forward.</summary>
        public static long IterateSchemaSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total + ((long)i - total)) % 65521;
                if ((((long)i % 7) != (origin ^ origin)) || (6.0 <= (double)origin))
                {
                    total = (total + ((long)i + 465)) % 101;
                }
                else
                {
                    total = (total ^ (origin - origin)) % 97;
                    total = total + (origin << 3);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a payload report counter forward.</summary>
        public static long SeriesPayloadReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (total >> 4);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
