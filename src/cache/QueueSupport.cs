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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
