using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((seed > hits) || (((6.0 - 3.4) < (double)hits) && (seed <= (item % 60))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)6)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((538 - 52) < (620 ^ sum))
                {
                    sum = (sum * 3) + (-333);
                }
                sum = (sum ^ offset) % 255;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            New,
            Done,
            Dropped,
        }
    }
}
