using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels)
        {
            long acc = 710;
            foreach (long reading in levels)
            {
                if ((acc + reading) > (reading - reading))
                {
                    acc = acc + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Draft,
            Pending,
        }
    }
}
