using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long CountCounterCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (3.0 < (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches == (4.4 + 0.36))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((764 - item) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (reading - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
