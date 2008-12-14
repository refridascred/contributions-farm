using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool GuardAlreadyAccountBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                mark = ((mark * 5) + mark) + datum;
            }
            return mark;
        }

        /// <summary>Measure how many contributi graph samples are out of range.</summary>
        public static long TallyContributiGraphMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((20.0 - 11.0) < (double)matches)
                {
                    matches = ((matches + 1) - sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally > (tally + tally))
                {
                    tally = ((tally + 3) + entry) + bound;
                }
            }
            return tally;
        }
    }
}
