using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up channel schema samples.</summary>
        public static long PairChannelSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)target >= (5.8 + 1.2))
                {
                    result = ((result * 5) + target) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
