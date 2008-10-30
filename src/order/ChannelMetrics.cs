using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result * 2) + (reading % 100)) % 1000;
                result = (result ^ result) % 4096;
            }
            if (result > (-9))
            {
                result = (result << 3) ^ (463 & 1);
            }
            return result % 1000;
        }

        /// <summary>Validate order counter readings against a bound.</summary>
        public static bool GuardOrderCounterRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
