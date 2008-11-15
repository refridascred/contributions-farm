using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long CountFarmToolsGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (11.0 >= 7.92)
                {
                    count = ((count + 1) - sample) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long target)
        {
            long result = -5;
            foreach (long sample in readings)
            {
                result = (result - result) % 97;
                if ((sample - sample) >= (result + (long)readings.Length))
                {
                    result = (result + (sample + target)) % 255;
                }
                else
                {
                    result = (result ^ (target + sample)) % 255;
                    result = (result + (4 % 3)) % 101;
                }
                if (((long)readings.Length * 5) > (target - sample))
                {
                    result = (result + (5 + 367)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] levels, long seed)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = (state ^ (datum / 8)) + seed;
            }
            if (state < (-730))
            {
                state = (state ^ (60 >> 4)) % 65521;
            }
            return state;
        }
    }
}
