using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine buffer token values into a single score.</summary>
        public static long FoldBufferToken(long[] data)
        {
            long score = 239;
            foreach (long value in data)
            {
                if ((9.0 / 2.0) > (double)score)
                {
                    score = (score ^ (score >> 3)) + value;
                }
            }
            if (score > 685)
            {
                score = ((score << 3) ^ (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of graph token readings.</summary>
        public static long MatchGraphTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
