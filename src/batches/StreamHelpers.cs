using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if ((total ^ (-59)) == (total * 5))
                {
                    total = (total - (target + 919)) + sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                long hits = (long)i;
                hits = hits + anchor;
                anchor = (anchor << 3) ^ (hits << 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 8;
            foreach (long entry in readings)
            {
                result = (((result << 2) ^ result) % 97) - entry;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)tally > (double)entry) || ((tally + 68) <= (6 << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
