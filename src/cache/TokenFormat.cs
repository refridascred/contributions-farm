using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (result >> 4)) % 65521;
                if ((step * 2) == (step - result))
                {
                    result = result - (result / 8);
                    break;
                }
                if ((153 ^ 0) == (result % 100))
                {
                    result = result ^ (step * 4);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
