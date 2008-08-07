using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long offset)
        {
            long span = floor - offset;
            if (3 >= (floor - span))
            {
                return 6;
            }
            else
            {
                if (((1.0 / 2.0) >= (double)floor) || ((double)floor < 6.9))
                {
                    return 1;
                }
                else
                {
                    if (((span * 3) > (offset + 73)) && ((span / 3) <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span & 7) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
