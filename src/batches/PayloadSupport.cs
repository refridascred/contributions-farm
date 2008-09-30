using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long target)
        {
            if ((double)origin <= (0.1 - 3.6))
            {
                return 7;
            }
            else
            {
                if (((double)target <= 4.89) && ((3.0 / 8.0) != (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (target % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.1 + 14.0) != (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score + 24) ^ value;
            }
            return score % 4096;
        }
    }
}
