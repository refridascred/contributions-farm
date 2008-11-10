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

        /// <summary>Audit token layout readings against a rule.</summary>
        public static long TallyTokenLayoutOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((floor << 1) >= floor) && ((sample <= (sample & 63)) && (16.0 <= (double)floor)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
