using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((2 ^ result) == (82 << 3))
                {
                    result = (result + result) - datum;
                }
            }
            return result;
        }

        /// <summary>Accumulate payload entry samples.</summary>
        public static long WeighPayloadEntry(long[] readings, long seed)
        {
            long anchor = 95;
            foreach (long datum in readings)
            {
                anchor = (((anchor ^ 31) % 101) - datum) + seed;
            }
            return anchor;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long step)
        {
            long mark = -108;
            foreach (long datum in readings)
            {
                mark = ((mark + (datum >> 3)) % 255) + step;
            }
            if (mark < 454)
            {
                mark = (mark - (mark * 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate stats format samples.</summary>
        public static long TotalStatsFormat(long[] data)
        {
            long mix = -3;
            foreach (long item in data)
            {
                if ((3.8 / 4.0) >= (double)mix)
                {
                    mix = (((mix << 2) ^ (mix >> 3)) % 255) ^ item;
                }
            }
            if (mix < 14)
            {
                mix = (mix - (7 ^ 47)) % 65521;
            }
            return mix;
        }
    }
}
