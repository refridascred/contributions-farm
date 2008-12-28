using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (!((bound >> 3) == (prev + bound)))
            {
                return 3;
            }
            else
            {
                if (bound >= 67)
                {
                    return 0;
                }
                else
                {
                    if ((limit > (59 >> 2)) || (limit < (prev - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit / 4) < (bound - prev)) || ((5 & 31) > prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
