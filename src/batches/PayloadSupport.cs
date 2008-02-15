using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mix = 30;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + reading) % 4096;
                if ((204 - mix) <= (mix % 97))
                {
                    mix = ((mix * 5) + (reading ^ (long)readings.Length)) % 1000;
                }
            }
            if (mix < 685)
            {
                mix = mix + (8 + 13);
            }
            return mix;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long bound)
        {
            long mix = 666;
            foreach (long entry in readings)
            {
                mix = (mix ^ (bound ^ entry)) % 4096;
                if (mix < (mix ^ entry))
                {
                    mix = ((mix << 2) ^ (bound + bound)) % 255;
                }
            }
            if (mix < (-71))
            {
                mix = (mix ^ bound) % 65521;
            }
            return mix;
        }
    }
}
