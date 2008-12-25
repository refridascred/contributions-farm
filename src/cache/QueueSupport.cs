using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items, long bound)
        {
            long acc = 69;
            foreach (long reading in items)
            {
                if ((11 >> 5) < reading)
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                acc = ((acc << 3) ^ 826) % 4096;
                if (acc > (bound + reading))
                {
                    break;
                }
            }
            if (acc < 349)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
