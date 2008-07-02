using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel counter samples.</summary>
        public static long TotalChannelCounter(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                if ((sample & 31) <= (1 - result))
                {
                    result = result ^ (sample * 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many cluster layout samples are out of range.</summary>
        public static long TallyClusterLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((step / 3) > seen))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
