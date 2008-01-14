using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] levels, long offset)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                if ((offset ^ 27) != (sample + result))
                {
                    result = result ^ offset;
                }
                if (((offset << 1) > result) && ((offset - sample) < (result >> 5)))
                {
                    break;
                }
            }
            if (result < 18)
            {
                result = (result - (offset & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8 >> 2) > (matches % 5))
                {
                    matches = ((matches + 2) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Stale,
            Paused,
        }
    }
}
