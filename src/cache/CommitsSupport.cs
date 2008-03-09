using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools counter readings.</summary>
        public static long PairToolsCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if ((double)mix == (6.33 + 20.0))
                {
                    mix = ((mix * 5) + (mix - reading)) % 4096;
                }
            }
            if (mix > 97)
            {
                mix = (mix + (mix - 308)) % 97;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > 931)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long LookupBatchStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
