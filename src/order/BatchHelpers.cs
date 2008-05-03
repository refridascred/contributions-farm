using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset - (long)i) < (offset + offset))
                {
                    score = score - (score >> 5);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score - score) % 4096) - (long)i2;
                }
                if ((score % 24) >= (offset + score))
                {
                    score = (score + offset) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long origin2)
        {
            long gap = origin - origin2;
            if (!((origin - origin) == (origin2 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((gap / 8) < (650 + origin))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
