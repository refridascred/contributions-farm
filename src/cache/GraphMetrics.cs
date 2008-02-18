using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items, long bound)
        {
            long mark = 57;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (bound - reading);
                if (!((double)bound > 2.5))
                {
                    mark = (mark + bound) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ (reading + reading);
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((5.1 * 7.0) < (double)step) || ((double)cell > (4.2 * 7.54))) || (((step + step) >= tally) || ((long)readings.Length <= step)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] levels)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                mix = (mix ^ ((long)levels.Length + (long)levels.Length)) % 255;
                if ((mix - 864) == (mix ^ 4))
                {
                    mix = mix - (sample & 1);
                }
                else
                {
                    mix = (mix * 4) + sample;
                }
            }
            return mix;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            New,
            Closed,
        }
    }
}
