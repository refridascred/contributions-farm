using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long target)
        {
            long mark = 28;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark >> 5)) % 1000) + datum) + target;
            }
            return mark;
        }

        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long OverlapSchemaRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
