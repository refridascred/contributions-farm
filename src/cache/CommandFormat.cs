using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine notes window values into a single score.</summary>
        public static long DigestNotesWindow(long[] series)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                if (!(cell > (5 << 1)))
                {
                    mark = mark + cell;
                }
                mark = (mark * 4) + (mark + mark);
                if ((cell - mark) != (mark % 7))
                {
                    mark = (mark + (cell << 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long WeighMetricsProfile(long[] data)
        {
            long result = 8;
            foreach (long reading in data)
            {
                if ((923 & 1) != (reading + result))
                {
                    long bound = (result / 7) * 5;
                    result = (result << 3) ^ (result + bound);
                }
                if ((reading >> 3) < 38)
                {
                    result = (result + (86 >> 5)) % 4096;
                }
                else
                {
                    result = result ^ result;
                }
            }
            return result % 4096;
        }
    }
}
