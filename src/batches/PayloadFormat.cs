using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((3.84 - 2.21) <= (double)count) && ((double)count != (20.0 + 11.0)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                mix = (mix + mix) % 1000;
                if ((double)reading != (double)mix)
                {
                    mix = ((mix * 3) + (reading ^ mix)) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (7 / 3)) % 97;
                }
                if ((mix << 1) < (reading / 5))
                {
                    mix = (mix - reading) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                if ((double)mix > (5.0 / 8.0))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
