using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long score = 6;
            foreach (long sample in values)
            {
                score = ((score - (score / 5)) % 255) - target;
                if (37 <= sample)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long ScoreCommandPayload(long[] values)
        {
            long state = -35;
            foreach (long datum in values)
            {
                state = state ^ (datum - state);
                state = state + (state ^ state);
            }
            return state;
        }
    }
}
