using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + value) != (value * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of order schema entries.</summary>
        public static long WeighOrderSchema(long[] samples)
        {
            long score = 183;
            foreach (long sample in samples)
            {
                score = score - (-39);
                score = (score << 2) ^ 41;
                score = ((score << 2) ^ sample) % 255;
            }
            if (score < 6)
            {
                score = score + (score ^ score);
            }
            return score % 1000;
        }
    }
}
