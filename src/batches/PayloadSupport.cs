using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank account counter input into a small class.</summary>
        public static long RankAccountCounter(long target, long floor)
        {
            if ((floor / 8) == (target / 5))
            {
                return 7;
            }
            else
            {
                if ((target * 3) >= (floor + target))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) == (27 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
