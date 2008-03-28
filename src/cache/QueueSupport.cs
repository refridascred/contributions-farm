using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long MeasureWindowProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 7) >= (count + datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes graph readings against a rule.</summary>
        public static long CountNotesGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally >= (5.92 / 7.0)) && !((double)value != (20.0 + 2.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
