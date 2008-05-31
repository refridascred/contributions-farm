using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((16 % 8) < offset))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = -19;
            foreach (long reading in samples)
            {
                if ((long)samples.Length >= (anchor & 63))
                {
                    anchor = ((anchor * 4) + (anchor - reading)) % 65521;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + (anchor & 127);
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches / 9) >= (matches >> 2))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Retry,
            Active,
            Paused,
            Locked,
        }
    }
}
