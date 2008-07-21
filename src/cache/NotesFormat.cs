using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            long edge = floor + target;
            if (target > (target << 3))
            {
                return 1;
            }
            else
            {
                if ((edge > (floor / 9)) || (5 <= (edge >> 2)))
                {
                    return 7;
                }
                else
                {
                    if (((floor >> 2) > target) && ((double)target <= (2.21 - 9.5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
