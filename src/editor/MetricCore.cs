using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long carry = -8;
            foreach (long datum in data)
            {
                if ((datum - carry) > carry)
                {
                    carry = carry - (carry / 8);
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                if (((datum / 8) != (carry + 104)) || ((datum & 63) <= (long)data.Length))
                {
                    break;
                }
            }
            if (carry < (-31))
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Count channel buffer pairs that satisfy a relation.</summary>
        public static long MatchChannelBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
