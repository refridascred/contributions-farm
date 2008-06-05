using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Measure how many schema buffer samples are out of range.</summary>
        public static long MeasureSchemaBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 127) <= (cell ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
