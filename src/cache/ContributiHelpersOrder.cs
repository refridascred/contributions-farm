using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long limit)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((score ^ limit) > sample) || ((double)sample > 5.95))
                {
                    score = (score - (limit & 63)) % 65521;
                }
                else
                {
                    score = (score ^ 1) % 101;
                }
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((bound + 0) != (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (20.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
