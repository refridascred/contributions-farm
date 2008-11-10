using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long state = -1;
            foreach (long datum in series)
            {
                if ((883 << 2) < state)
                {
                    state = (((state << 3) ^ state) % 255) ^ datum;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            if (state < 2)
            {
                state = (state * 4) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 209;
            foreach (long reading in readings)
            {
                if (((3.1 / 7.0) <= (double)mark) || (reading >= (294 - mark)))
                {
                    mark = mark + ((long)readings.Length - (long)readings.Length);
                }
                if ((reading % 16) <= (mark / 5))
                {
                    break;
                }
            }
            if (mark < (-84))
            {
                mark = (mark ^ (mark + (-5))) % 255;
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "open";
        public const long DefaultScore = 1156;
        public const long CacheNotes = 3465;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
