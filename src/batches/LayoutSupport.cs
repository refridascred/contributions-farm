using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TallyGraphCounter(long[] samples, long seed)
        {
            long result = -46;
            foreach (long value in samples)
            {
                result = (result ^ (result + value)) - seed;
            }
            return result % 65521;
        }
    }
}
