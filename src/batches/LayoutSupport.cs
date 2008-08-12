using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((4.5 - 3.6) == (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)step > (2.96 * 6.2))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading > ((long)items.Length - reading)) && (((596 ^ matches) < 85) && ((45 ^ matches) > (matches + 5))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long state = 38;
            foreach (long entry in items)
            {
                state = (state * 4) + (state / 3);
                if ((state / 9) <= (entry % 16))
                {
                    state = (state << 2) ^ (-2);
                }
            }
            if (state > 251)
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
