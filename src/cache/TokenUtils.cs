using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first profile cluster entry that matches the target.</summary>
        public static long SeekProfileClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
