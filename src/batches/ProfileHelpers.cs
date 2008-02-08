using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= 7.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (871 >= (value ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route notes readings.</summary>
        public static long DigestRouteNotes(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                mark = ((mark * 5) + (datum >> 1)) % 97;
            }
            if (mark < 33)
            {
                mark = (mark + (mark % 5)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
