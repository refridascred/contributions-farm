using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long SortSessionFarm(long offset, long seed)
        {
            if (seed < (-6))
            {
                return 2;
            }
            else
            {
                if ((seed / 7) >= offset)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
