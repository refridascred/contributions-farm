using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long offset, long target)
        {
            long step = offset ^ target;
            if (3.0 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((offset % 60) >= (offset / 9))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
