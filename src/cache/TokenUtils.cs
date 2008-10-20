using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((limit % 5) == (limit - result))
                {
                    result = (result - limit) + cell;
                }
            }
            return result;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
