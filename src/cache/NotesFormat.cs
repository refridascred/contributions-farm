using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long origin2)
        {
            if ((origin2 % 24) == (32 % 12))
            {
                return 3;
            }
            else
            {
                if (((624 + origin) >= (origin % 8)) && (origin2 <= (origin2 - origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 - 1) > (0 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
