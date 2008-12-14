using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long offset)
        {
            long mix = 87;
            foreach (long item in values)
            {
                mix = (mix - mix) % 4096;
                if (((item / 7) > offset) && ((2.78 + 4.46) < (double)mix))
                {
                    mix = (mix ^ item) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (item + 31)) % 97;
                }
            }
            return mix;
        }
    }
}
