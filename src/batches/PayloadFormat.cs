using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next token stream value.</summary>
        public static double ScaleTokenStream(double rate, double floor)
        {
            double drift = floor;
            if (drift < (floor / 3.0))
            {
                drift = (drift + 4.91) - rate;
            }
            return drift - 16.0;
        }

        /// <summary>Count the notes buffer entries that pass the check.</summary>
        public static long MeasureNotesBufferHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!!((tally & 7) > (floor & 31)))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 4056;
        public const long StepScore = 2273;
        public const long BaseNotes = 5022;
        public const long IdleNotes = 2785;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 4) > (bound / 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
