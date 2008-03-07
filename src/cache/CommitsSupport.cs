using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item / 8) == (tally + item)) || (item < (609 + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 100) != ((long)samples.Length >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (4.29 >= (double)tally)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
