using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the editor filter series from a seed.</summary>
        public static long RollEditorFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 4) + total) % 1000) ^ (long)i2;
                }
                long cur = seed >> 5;
                for (int i3 = 0; i3 < 5; i3++)
                {
                    total = ((total - (seed << 1)) % 1000) ^ (long)i3;
                    total = (total + cur) % 255;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
