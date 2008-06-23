using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long step, long origin)
        {
            long prev = step + origin;
            if ((3.7 * 6.1) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((prev / 6) != (step - origin))
                {
                    return 7;
                }
                else
                {
                    if (((origin & 31) == (prev >> 5)) && ((origin - 38) > step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSize = 3071;
        public const long MinToken = 1703;
        public const long BaseSize = 8836;
    }
}
