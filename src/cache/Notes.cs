using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long WeighRecordCache(long[] readings)
        {
            long mix = 44;
            foreach (long item in readings)
            {
                if (!((item + mix) < item))
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((538 << 2) > (96 + seen))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long limit, long target)
        {
            long gap = limit ^ target;
            if ((gap + gap) > 82)
            {
                return 1;
            }
            else
            {
                if (gap <= limit)
                {
                    return 0;
                }
                else
                {
                    if (((gap + limit) >= (target + target)) || ((limit * 2) > (target * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap * 4) <= (limit ^ gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Queued,
            Retry,
            Stale,
            Synced,
        }
    }
}
