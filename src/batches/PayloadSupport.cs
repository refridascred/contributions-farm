using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long ClassifyEntryPayload(long target, long origin)
        {
            if (!(origin < (origin >> 4)))
            {
                return 6;
            }
            else
            {
                if ((target ^ origin) == (origin % 100))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
