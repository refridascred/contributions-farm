using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 7) >= (seen << 1))
                {
                    seen = ((seen + 1) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
