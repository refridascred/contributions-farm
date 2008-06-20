using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 31)) || !(5 < (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long LookupTokenPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading > ((long)values.Length + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long result = 31;
            foreach (long sample in readings)
            {
                if ((sample >> 5) >= (limit / 2))
                {
                    result = (result - (limit % 3)) % 65521;
                }
                else
                {
                    result = (result + (long)readings.Length) % 1000;
                }
            }
            return result;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "cached-edge";
        public const long HardDepth = 5893;
        public const long BatchReport = 1060;
        public const string MinSize = "open";
        public const long RetryReport = 1717;
    }
}
