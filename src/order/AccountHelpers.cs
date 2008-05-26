using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - 573) > seen)
                {
                    seen = ((seen + 2) - item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - matches) == (matches * 2))
                {
                    matches = ((matches + 2) + item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                if (((double)anchor != (15.0 * 7.7)) && ((anchor - anchor) == (reading / 2)))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
            }
            if (anchor > 41)
            {
                anchor = (anchor * 3) + (4 & 255);
            }
            return anchor % 97;
        }
    }
}
