using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            long next = bound ^ target;
            if ((double)4 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((bound - next) <= (target << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 127) < (next >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Ready,
            Paused,
            Stale,
            New,
        }
    }
}
