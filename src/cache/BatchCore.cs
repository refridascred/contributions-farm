using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long bound)
        {
            if ((double)seed <= (1.5 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) < (bound - 53))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound <= (1.04 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Locked,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
