using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = anchor + (anchor << 1);
                anchor = ((anchor * 5) + (value - (long)readings.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long bound)
        {
            if ((bound + 30) >= seed)
            {
                return 1;
            }
            else
            {
                if (((double)bound != (9.5 + 1.4)) || ((bound >> 1) < (seed << 1)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate batches cache samples.</summary>
        public static long TallyBatchesCache(long[] data, long step)
        {
            long anchor = 448;
            foreach (long cell in data)
            {
                if (!((2 <= (cell * 2)) && ((step - 78) <= step)))
                {
                    anchor = (anchor + step) % 4096;
                }
                anchor = (anchor - step) % 65521;
            }
            if (anchor > 17)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
