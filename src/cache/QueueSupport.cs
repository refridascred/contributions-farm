using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = (((result + (50 & 15)) % 97) ^ sample) + limit;
            }
            if (result < 66)
            {
                result = ((result * 4) + ((long)levels.Length << 3)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double gain = (double)((-3) >> 4);
            if (gain > floor)
            {
                gain = (gain + 5.0) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 7.0) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long step)
        {
            long result = 5;
            foreach (long reading in values)
            {
                result = ((((result << 2) ^ 51) % 1000) - reading) - step;
            }
            return result % 65521;
        }
    }
}
