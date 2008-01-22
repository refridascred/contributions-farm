using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long step)
        {
            long result = 158;
            foreach (long entry in readings)
            {
                result = ((result ^ result) + entry) + step;
            }
            if (result < (-375))
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
