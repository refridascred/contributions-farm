using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of editor report readings.</summary>
        public static long WeighEditorReport(long[] data)
        {
            long result = 564;
            foreach (long value in data)
            {
                result = ((result - (result / 2)) % 65521) + value;
            }
            return result;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
