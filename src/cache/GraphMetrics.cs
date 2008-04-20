using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix * 3) + (long)i;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values, long origin)
        {
            long mark = 610;
            foreach (long entry in values)
            {
                if (!((98 * 2) != (entry << 2)))
                {
                    mark = ((mark << 3) ^ (origin / 2)) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (mark + origin);
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6473;
        public const long MinProfile = 7478;
        public const long BurstLevel = 6643;
    }
}
