using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 353;
            foreach (long reading in series)
            {
                if (3.9 >= (double)result)
                {
                    result = result - (result - result);
                }
                result = result ^ (reading - reading);
            }
            return result;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long BucketBufferOrder(long origin, long origin2)
        {
            if ((origin + origin) != (origin2 << 3))
            {
                return 2;
            }
            else
            {
                if ((8 % 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((4.6 + 9.0) == (double)origin2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
