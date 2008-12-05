using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache stats samples.</summary>
        public static long ScoreCacheStats(long[] levels)
        {
            long total = 56;
            foreach (long reading in levels)
            {
                total = ((total << 3) ^ reading) % 65521;
                if (total <= (total & 7))
                {
                    total = (total ^ (total ^ reading)) % 1000;
                }
                else
                {
                    total = (total * 2) + total;
                }
            }
            return total;
        }

        /// <summary>Locate a cluster contributi reading by value.</summary>
        public static long LocateClusterContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            New,
            Failed,
            Done,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if ((limit % 2) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset & 1)) && ((double)limit < (7.09 + 2.9)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
