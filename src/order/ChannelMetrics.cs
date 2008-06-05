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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 2) ^ (98 * 2)) % 101;
                if (((19.0 + 19.0) == (double)result) || ((result * 4) < (step << 3)))
                {
                    result = (result << 3) ^ (result / 5);
                    result = (result << 3) ^ (step % 24);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
