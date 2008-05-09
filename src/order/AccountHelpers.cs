using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen >> 5))
                {
                    seen = ((seen + 2) + item) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits >> 5))
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

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items)
        {
            long carry = 690;
            foreach (long reading in items)
            {
                if (((carry % 12) < (carry ^ reading)) && ((double)carry < (7.0 / 3.0)))
                {
                    carry = (carry * 4) + (carry + 6);
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultSize = "primary";
        public const string RetryStats = "alpha-1";
        public const long IdleDepth = 47;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (39 <= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
