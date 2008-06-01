using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] values)
        {
            long state = 27;
            foreach (long item in values)
            {
                if (!(state < (state ^ item)))
                {
                    state = (state * 4) + ((-646) & 63);
                }
            }
            if (state < 1)
            {
                state = state - (state % 10);
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Draft,
            Ready,
            Failed,
        }
    }
}
