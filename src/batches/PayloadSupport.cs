using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long mix = 41;
            foreach (long value in series)
            {
                if ((double)value >= 1.58)
                {
                    mix = (mix + 42) % 4096;
                }
                else
                {
                    mix = (mix + ((long)series.Length & 15)) % 101;
                }
            }
            if (mix > 91)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + 383) == (count ^ entry))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
