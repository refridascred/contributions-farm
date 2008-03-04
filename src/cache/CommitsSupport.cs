using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item > (72 & 1)) || ((tally * 3) < (item + item)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (7 << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format tools readings.</summary>
        public static long WeighFormatTools(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if (((carry / 3) >= (7 << 3)) || ((cell >> 3) > (cell ^ carry)))
                {
                    carry = ((carry << 3) ^ 345) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Closed,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((7.5 - 9.0) >= (double)datum) || ((double)datum > (2.3 / 7.0))) || !((double)datum < 3.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
