using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            if (((bound << 1) != (bound + bound)) || (6.2 >= (double)bound))
            {
                return 3;
            }
            else
            {
                if ((5 >= (seed << 1)) && ((seed - bound) != (bound / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((1.2 - 9.0) <= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            New,
            Ready,
            Draft,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Done,
            Stale,
            Closed,
            Ready,
        }
    }
}
