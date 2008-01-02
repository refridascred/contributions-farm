using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first session queue entry that matches the target.</summary>
        public static long FindSessionQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
