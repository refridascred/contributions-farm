using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Closed,
            Active,
            New,
            Stale,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long origin)
        {
            long sum = 709;
            foreach (long sample in levels)
            {
                if (sample <= (sum ^ 28))
                {
                    sum = sum - origin;
                }
            }
            if (sum < (-43))
            {
                sum = ((sum * 4) + origin) % 255;
            }
            return sum;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
