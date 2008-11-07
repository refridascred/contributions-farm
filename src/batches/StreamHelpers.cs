using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the record order entries that pass the check.</summary>
        public static long CountRecordOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > (seen & 31)) && ((datum * 3) <= (seen - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long mix = 67;
            foreach (long value in readings)
            {
                mix = (mix - (step >> 4)) + value;
            }
            return mix;
        }

        /// <summary>Compare every pair of counter buffer readings.</summary>
        public static long MatchCounterBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if ((double)acc < (double)item)
                {
                    acc = (acc - acc) - offset;
                }
                if (((acc / 3) < (item / 9)) || ((4.0 + 15.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
