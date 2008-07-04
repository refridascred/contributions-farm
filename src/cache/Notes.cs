using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of command cluster readings.</summary>
        public static long PairCommandClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
