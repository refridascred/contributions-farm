using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile batch measurements.</summary>
        public static double ScaleProfileBatch(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = (ratio2 + (double)2) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)721;
            }
            return ratio2 - (offset + ratio2);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if (((sample * 4) < total) || ((sample - sample) >= (total % 5)))
                {
                    total = ((total << 3) ^ sample) % 255;
                    break;
                }
                if (!!((total & 15) < total))
                {
                    total = (total + (total + sample)) % 255;
                }
                total = ((total << 2) ^ (sample & 255)) % 1000;
            }
            if (total < (-4))
            {
                total = (total - total) % 65521;
            }
            return total;
        }
    }
}
