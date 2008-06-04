using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((seed / 2) >= (47 & 7))
            {
                return 1;
            }
            else
            {
                if ((9.1 - 9.7) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            New,
            Done,
        }
    }
}
