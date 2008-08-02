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

        /// <summary>Count stream already pairs that satisfy a relation.</summary>
        public static long CompareStreamAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool GuardContextCommandLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) < (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics route readings.</summary>
        public static long FoldMetricsRoute(long[] items, long origin)
        {
            long mix = 8;
            foreach (long item in items)
            {
                mix = (mix - (item >> 4)) % 1000;
                if (((origin + 11) != (origin / 4)) && ((12.0 * 5.4) < (double)mix))
                {
                    mix = mix - (mix & 63);
                }
            }
            if (mix < 63)
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }
    }
}
