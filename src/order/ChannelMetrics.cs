using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long carry = 4;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length & 7) < carry))
                {
                    carry = (carry << 2) ^ (reading - reading);
                }
                if ((reading <= (reading - 25)) && ((reading >> 4) == (carry + carry)))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
