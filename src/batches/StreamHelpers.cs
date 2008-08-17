using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 21;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = result - (result / 6);
                    result = ((result * 5) + ((long)i * 4)) % 4096;
                }
                result = (result + (datum * 3)) % 255;
            }
            return result;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3052;
        public const long MaxContext = 6548;
        public const double DefaultContext = 30.01;
        public const long MaxSpan = 7268;
    }
}
