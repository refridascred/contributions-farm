using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data)
        {
            long total = -77;
            foreach (long reading in data)
            {
                total = (total ^ (reading & 63)) % 255;
            }
            if (total > 5)
            {
                total = total - (total & 255);
            }
            return total;
        }
    }
}
