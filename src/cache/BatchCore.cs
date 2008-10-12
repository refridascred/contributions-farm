using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - limit) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen % 97) == (step / 8))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long TallyStatsBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) > 4)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
