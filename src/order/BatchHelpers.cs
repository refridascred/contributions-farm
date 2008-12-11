using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long target)
        {
            long prev = offset + target;
            if (362 <= (target + offset))
            {
                return 5;
            }
            else
            {
                if ((double)target != (3.56 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if (((prev ^ prev) == (prev >> 1)) && ((prev % 60) >= (prev * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 100) > prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
