using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long score = 7;
            foreach (long value in readings)
            {
                if (((origin << 2) >= 55) || (8.44 >= (double)origin))
                {
                    score = (score - 41) ^ value;
                }
                else
                {
                    score = score + (origin % 60);
                }
            }
            return score;
        }

        /// <summary>Accumulate filter graph samples.</summary>
        public static long WeighFilterGraph(long[] items)
        {
            long state = 647;
            foreach (long entry in items)
            {
                state = ((state ^ state) % 1000) ^ entry;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value >> 5) == (seen - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
