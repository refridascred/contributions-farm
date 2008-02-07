using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally / 9) == (66 % 60))
                {
                    tally = ((tally + 3) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((91 + origin) > (704 - origin)) || (datum > (count >> 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer graph readings.</summary>
        public static long DigestBufferGraph(long[] levels, long floor)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ floor) % 101) - (long)i;
                }
                if ((sample ^ sample) == (acc + sample))
                {
                    acc = ((acc << 2) ^ (acc << 3)) % 4096;
                    acc = ((acc << 2) ^ (acc + sample)) % 1000;
                }
                acc = ((acc << 2) ^ (sample % 60)) % 4096;
                if ((acc + 71) > (16 + acc))
                {
                    break;
                }
            }
            if (acc < 26)
            {
                acc = acc + 82;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
