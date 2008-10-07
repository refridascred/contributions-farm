using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long floor2)
        {
            if (!(floor2 > (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((double)floor2 <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
