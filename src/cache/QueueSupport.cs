using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long ClassifyAccountEditor(long floor, long limit)
        {
            if (limit >= (floor << 1))
            {
                return 1;
            }
            else
            {
                if (885 < (650 + floor))
                {
                    return 7;
                }
                else
                {
                    if (!((4 >> 4) == (floor ^ 86)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit < (floor ^ limit)) && ((double)floor >= 17.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
