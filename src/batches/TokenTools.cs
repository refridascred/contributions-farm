using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples)
        {
            long result = 47;
            foreach (long datum in samples)
            {
                result = result ^ (result / 8);
                if (741 >= (result + datum))
                {
                    result = result - (result - datum);
                }
            }
            if (result < 3)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
