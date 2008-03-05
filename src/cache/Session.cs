using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long origin)
        {
            if (!((origin >> 1) == (origin - bound)))
            {
                return 3;
            }
            else
            {
                if ((origin - bound) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 4) >= (bound + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count entry layout pairs that satisfy a relation.</summary>
        public static long OverlapEntryLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long mark = 393;
            foreach (long value in readings)
            {
                if (5 > (value ^ value))
                {
                    mark = ((mark * 3) + value) % 65521;
                }
            }
            return mark;
        }
    }
}
