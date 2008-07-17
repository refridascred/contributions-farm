using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long acc = 966;
            foreach (long value in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - floor) ^ (long)i) ^ value;
                }
                acc = ((acc * 5) + (acc % 64)) % 65521;
                acc = (acc << 2) ^ floor;
            }
            return acc % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
