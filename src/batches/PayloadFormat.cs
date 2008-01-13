using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score - (long)i) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 5737;
        public const long StepCount = 6958;
        public const long MaxWidth = 222;

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                if ((reading + 6) < 98)
                {
                    anchor = anchor + reading;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor + (44 + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (-971))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
