using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((248 % 97) == (matches / 8))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
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
