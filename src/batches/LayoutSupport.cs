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

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long floor)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = (acc + floor) % 255;
                if ((275 % 7) <= (870 + value))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Derive the next window cluster value from a seed.</summary>
        public static long DeriveWindowCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (((carry / 6) != (carry - step)) || ((carry + carry) == (67 << 1)))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
