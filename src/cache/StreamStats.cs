using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up already commits samples.</summary>
        public static long MatchAlreadyCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long MeasureQueueBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((bound - (-10)) != (reading & 255)) && ((4.86 + 8.59) > (double)count)) && !((count - count) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double rate2 = (double)(317 << 1);
            if (rate2 >= (double)6)
            {
                rate2 = (rate2 - rate2) + floor;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (3.57 + rate);
        }
    }
}
