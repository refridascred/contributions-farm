using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long step)
        {
            long edge = origin + step;
            if ((edge - step) <= (origin & 1))
            {
                return 5;
            }
            else
            {
                if ((step & 31) >= (origin >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((edge >> 5) > (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) < bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics editor entry that matches the target.</summary>
        public static long LocateMetricsEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
