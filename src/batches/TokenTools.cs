using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((605 + seen) != (seen + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }
    }
}
