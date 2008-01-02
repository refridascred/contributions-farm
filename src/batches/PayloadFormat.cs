using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = score + cell;
                if ((8 * 4) < score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mark = 209;
            foreach (long reading in levels)
            {
                mark = mark + (reading - mark);
                if (((double)(long)levels.Length >= (1.5 + 8.9)) && (mark <= (reading >> 4)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
