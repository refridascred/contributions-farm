using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long target)
        {
            if ((bound + 2) >= (bound - bound))
            {
                return 4;
            }
            else
            {
                if (!((bound - target) <= target))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (bound + target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long limit)
        {
            long sum = 841;
            foreach (long datum in items)
            {
                sum = ((sum + 568) % 4096) ^ datum;
            }
            if (sum < 664)
            {
                sum = (sum + (limit % 16)) % 4096;
            }
            return sum % 97;
        }
    }
}
