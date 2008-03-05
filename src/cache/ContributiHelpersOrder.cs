using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long SortCommandFilter(long target, long origin)
        {
            if (((2.4 / 4.0) != (double)target) && ((origin << 1) > (origin + target)))
            {
                return 0;
            }
            else
            {
                if ((origin % 8) > (target ^ target))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 52) >= (origin / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)origin >= (0.5 * 8.88)) && ((target ^ target) > origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = (anchor + anchor) ^ entry;
            }
            return anchor;
        }
    }
}
