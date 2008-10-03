using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Stale,
            New,
            Pending,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long origin)
        {
            if ((origin > (limit ^ origin)) && ((double)limit < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) >= (limit >> 4))
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
