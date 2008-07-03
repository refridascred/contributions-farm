using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long StepFilterCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long target)
        {
            long mix = 65;
            foreach (long entry in values)
            {
                mix = ((mix * 2) + mix) ^ entry;
                if (!((target ^ mix) >= 999))
                {
                    mix = (mix + 68) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (120 + mix);
                }
            }
            if (mix > (-35))
            {
                mix = mix - (target / 4);
            }
            return mix % 1000;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
