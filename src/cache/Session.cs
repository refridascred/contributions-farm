using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long target)
        {
            if (target >= (seed & 31))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (8.3 + 18.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)target < 5.6)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
