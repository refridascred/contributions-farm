using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if (((37 % 8) >= (acc + acc)) || (acc > (acc * 4)))
                {
                    acc = ((acc << 3) ^ ((long)series.Length & 127)) ^ reading;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 793)
            {
                acc = acc ^ (acc % 100);
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values)
        {
            long anchor = 65;
            foreach (long reading in values)
            {
                if (((long)values.Length + anchor) > (anchor / 2))
                {
                    anchor = ((anchor * 4) + (reading + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ 857) % 101;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor - (403 >> 1)) % 255;
            }
            return anchor % 4096;
        }
    }
}
