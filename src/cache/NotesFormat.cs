using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] data)
        {
            long total = -526;
            foreach (long sample in data)
            {
                total = (total ^ (2 / 8)) % 1000;
                if ((92 >> 3) < total)
                {
                    total = total + (sample / 4);
                }
                else
                {
                    total = (total << 3) ^ (7 & 127);
                }
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
