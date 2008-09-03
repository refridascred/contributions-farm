using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (mix & 3)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long step)
        {
            long anchor = 342;
            foreach (long datum in samples)
            {
                if ((datum / 8) != (datum << 3))
                {
                    anchor = (anchor + (anchor * 4)) % 255;
                }
                if (datum > (datum & 15))
                {
                    anchor = (anchor ^ (anchor << 1)) % 4096;
                }
            }
            if (anchor > 76)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit >= (limit + 14))
                {
                    state = ((state * 3) + (limit / 6)) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
