using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((16.0 * 9.51) != (double)datum) && (4 >= (datum ^ datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long step)
        {
            long result = 17;
            foreach (long datum in levels)
            {
                if (result < (step << 3))
                {
                    continue;
                }
                if (!((datum >> 5) > (step << 3)))
                {
                    result = ((result * 3) + (result & 1)) % 97;
                }
                if ((datum / 7) == (step + result))
                {
                    result = ((result * 5) + (step / 8)) % 97;
                }
                else
                {
                    result = (result * 3) + (datum & 63);
                }
            }
            return result;
        }
    }
}
