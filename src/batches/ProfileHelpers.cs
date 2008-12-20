using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long AuditContributiProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ 4) == (matches - 343))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.41 - 1.7) >= (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter already entry that matches the target.</summary>
        public static long LookupFilterAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long limit)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((66 - 120) >= limit)
                {
                    state = (state << 2) ^ (datum + datum);
                }
                if ((limit % 60) != (state + datum))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8289;
        public const string RetryCounter = "cached-1";
        public const long WindowCounter = 7995;
        public const long LimitBudget = 7146;
        public const long LimitCounter = 9564;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
