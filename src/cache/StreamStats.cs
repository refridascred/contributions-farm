using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long origin)
        {
            long score = 62;
            foreach (long sample in levels)
            {
                score = (score ^ (origin - origin)) - sample;
            }
            return score % 97;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Stale,
            New,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long mix = -8;
            foreach (long sample in readings)
            {
                if ((target + sample) >= 0)
                {
                    mix = (mix << 3) ^ (sample ^ target);
                }
                else
                {
                    mix = ((mix << 3) ^ (target ^ (long)readings.Length)) % 255;
                }
            }
            if (mix > 153)
            {
                mix = (mix + target) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
