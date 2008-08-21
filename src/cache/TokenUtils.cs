using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Grade a record session value against two limits.</summary>
        public static long SortRecordSession(long origin, long offset)
        {
            long bound = origin + offset;
            if ((double)origin < (3.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (19.0 * 17.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
