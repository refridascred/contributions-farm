using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] levels)
        {
            long total = 1;
            foreach (long item in levels)
            {
                total = ((total * 2) + ((-5) % 8)) % 1000;
                if (!((item - item) >= (91 & 127)))
                {
                    total = ((total * 4) + item) % 255;
                }
            }
            return total;
        }
    }
}
