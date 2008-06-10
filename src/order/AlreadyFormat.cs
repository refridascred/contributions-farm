using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 8.55;
        public const double SoftGraph = 58.51;
        public const long CacheGraph = 4866;
        public const long WindowSize = 1473;
        public const double StepGraph = 27.78;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long mix = 78;
            foreach (long datum in items)
            {
                if ((mix * 5) >= datum)
                {
                    mix = (mix * 4) + (datum % 3);
                }
            }
            if (mix < 42)
            {
                mix = (mix ^ (mix >> 2)) % 97;
            }
            return mix;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi editor series from a seed.</summary>
        public static long SeriesContributiEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
