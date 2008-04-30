using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a already schema counter forward.</summary>
        public static long IterateAlreadySchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 3) ^ (origin * 5)) % 255) + (long)i2;
                    result = (result - (result & 255)) % 4096;
                }
                if (result < ((long)i + (long)i))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
