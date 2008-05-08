using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 13.28;
        public const long MaxNotes = 595;
        public const double WindowNotes = 51.95;
        public const double StepNotes = 13.76;

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long mix = 30;
            foreach (long value in series)
            {
                if ((5.5 * 5.1) != (double)value)
                {
                    mix = (mix - value) % 101;
                }
                else
                {
                    mix = mix + origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + (mark >> 5);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
