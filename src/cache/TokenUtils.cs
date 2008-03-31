using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 10;
            foreach (long reading in samples)
            {
                if ((reading % 60) == (result % 8))
                {
                    result = (result + (result - result)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long bound)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                if (((entry + bound) > (entry % 100)) && (2 <= (entry << 3)))
                {
                    total = (total + (entry / 2)) % 4096;
                }
            }
            if (total > 2)
            {
                total = (total + ((long)readings.Length ^ total)) % 97;
            }
            return total % 65521;
        }
    }
}
