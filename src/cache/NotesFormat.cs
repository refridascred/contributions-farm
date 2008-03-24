using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long OverlapBatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            if ((double)offset == (3.75 / 7.0))
            {
                return 2;
            }
            else
            {
                if (!(173 >= (floor ^ offset)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
