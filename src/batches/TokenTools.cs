using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ step) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                result = ((result << 3) ^ sample) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
