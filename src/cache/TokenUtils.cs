using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
