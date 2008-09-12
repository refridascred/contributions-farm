using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Closed,
            New,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items)
        {
            long result = 361;
            foreach (long reading in items)
            {
                result = result + reading;
                result = (result * 3) + reading;
            }
            if (result < (-286))
            {
                result = result - (283 % 100);
            }
            return result;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long CountCacheStreamGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 3) != (count ^ item))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
