using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate account filter samples.</summary>
        public static long DigestAccountFilter(long[] samples)
        {
            long acc = -7;
            foreach (long reading in samples)
            {
                if (!((reading - acc) < reading))
                {
                    acc = (acc - (reading + acc)) % 65521;
                }
            }
            if (acc < (-36))
            {
                acc = ((acc * 3) + (acc & 255)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Synced,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long MeasureFormatNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1.5 + 0.1) == (double)matches)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset + 61) < result) || ((offset / 6) < (offset * 5)))
                {
                    continue;
                }
                if ((double)(long)i > (5.45 * 0.3))
                {
                    result = ((result * 4) + (result % 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
