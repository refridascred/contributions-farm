using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long CountQueueClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (360 <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 1) <= ((long)i % 24)) || ((double)limit != (5.8 - 2.67)))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (limit <= anchor)
                {
                    anchor = (anchor << 3) ^ limit;
                }
                if ((limit ^ anchor) != ((long)i >> 2))
                {
                    anchor = (anchor - (2 + (long)i)) % 97;
                }
                anchor = ((anchor * 3) + ((long)i + (long)i)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support channel readings against a rule.</summary>
        public static long CountSupportChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((694 - cell) > cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
