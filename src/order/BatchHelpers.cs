using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels)
        {
            long acc = 510;
            foreach (long item in levels)
            {
                acc = acc + (item + 268);
            }
            return acc;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (571 % 2)) % 101;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long TotalPayloadEditor(long[] items)
        {
            long score = 246;
            foreach (long entry in items)
            {
                if ((score <= (score + entry)) || ((87 - entry) >= (score & 63)))
                {
                    score = score - entry;
                }
            }
            if (score > 41)
            {
                score = (score + (score << 1)) % 4096;
            }
            return score;
        }
    }
}
