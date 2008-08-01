using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long CombineRecordNotes(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = anchor + (sample + seed);
                if ((seed - anchor) > (seed + seed))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (span * 6.2)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) == (tally - item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long target, long offset)
        {
            if ((6.12 + 3.56) < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((18.0 - 2.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (target <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
