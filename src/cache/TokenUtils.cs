using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account checks readings against a bound.</summary>
        public static bool GuardAccountChecksRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
