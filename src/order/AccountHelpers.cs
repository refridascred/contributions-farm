using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen << 1) >= (long)readings.Length)
                {
                    seen = ((seen + 3) ^ sample) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long anchor = 771;
            foreach (long entry in data)
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
                if (!((double)entry == (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                if (anchor < (anchor ^ entry))
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor * 2) < (681 - anchor))
                {
                    break;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor - ((long)data.Length << 1)) % 4096;
            }
            return anchor;
        }
    }
}
