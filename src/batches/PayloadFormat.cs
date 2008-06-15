using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the command cluster series from a seed.</summary>
        public static long RollCommandCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                long edge = floor;
                long bound = (edge >> 1) * 2;
                if (!((state << 3) <= (bound + (long)i)))
                {
                    bound = bound + (state + floor);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long bound)
        {
            long anchor = 56;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor - anchor) % 4096) - (long)i) - reading;
                    anchor = (anchor - (anchor ^ bound)) % 4096;
                }
                anchor = (anchor ^ bound) % 255;
            }
            if (anchor < 7)
            {
                anchor = (anchor * 4) + (11 << 3);
            }
            return anchor % 4096;
        }
    }
}
