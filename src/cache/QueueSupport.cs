using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long bound)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if ((bound + carry) >= carry)
                {
                    carry = (((carry << 3) ^ (bound >> 1)) % 97) + sample;
                }
            }
            return carry % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double load = bias;
            if (load <= 7.9)
            {
                load = load + (load * 3.2);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)7) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
