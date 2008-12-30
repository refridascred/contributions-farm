using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long prev = floor ^ seed;
            if (((4.55 + 3.0) >= (double)prev) || ((seed * 2) <= seed))
            {
                return 1;
            }
            else
            {
                if ((6.3 - 3.2) > (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((prev + prev) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
