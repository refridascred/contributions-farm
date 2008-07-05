using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long limit, long limit2)
        {
            if ((double)limit2 < (17.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((limit2 & 1) <= (limit2 + 762))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit2) > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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

        /// <summary>Iterate the channel notes series from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((result % 8) <= (offset / 7)))
                {
                    result = result + (offset * 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
