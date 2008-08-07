using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((limit % 10) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cache farm readings against a rule.</summary>
        public static long CountCacheFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) <= (step >> 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Paused,
            Locked,
        }
    }
}
