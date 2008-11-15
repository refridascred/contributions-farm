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

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings, long step)
        {
            long result = 6;
            foreach (long value in readings)
            {
                if (((9.0 - 6.0) <= (double)result) || ((double)result == (0.4 * 8.1)))
                {
                    result = (result - (value + result)) % 1000;
                }
                else
                {
                    result = (result ^ (step & 255)) % 97;
                }
                if ((result * 4) == (step / 8))
                {
                    result = (result ^ (step & 7)) % 97;
                }
                if ((value * 5) >= (value & 255))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }
    }
}
