using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((3.9 + 1.7) >= (double)diff)
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) > (808 - offset))
                {
                    return 7;
                }
                else
                {
                    if ((7 >> 3) != (diff - 898))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.88 - 0.05) > (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
