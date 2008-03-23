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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
