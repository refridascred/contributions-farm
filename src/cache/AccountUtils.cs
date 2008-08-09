using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            long delta = origin - step;
            if ((delta + delta) == (origin + delta))
            {
                return 8;
            }
            else
            {
                if (((1 + step) < origin) && ((8.1 + 4.72) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= 10.0)
                    {
                        return 7;
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
