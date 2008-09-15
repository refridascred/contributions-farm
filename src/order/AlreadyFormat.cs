using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long bound)
        {
            long carry = -80;
            foreach (long reading in samples)
            {
                carry = ((carry * 5) + (8 / 7)) - reading;
                carry = ((carry * 4) + (bound >> 1)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels)
        {
            long mix = 23;
            foreach (long item in levels)
            {
                if ((mix + mix) < (mix >> 2))
                {
                    mix = (mix - (item + 269)) % 255;
                }
            }
            if (mix > 904)
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool ValidateFormatPayloadRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (double)669)
            {
                gain = gain - (weight - 9.76);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
