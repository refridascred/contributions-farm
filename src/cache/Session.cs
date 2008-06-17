using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long offset)
        {
            long state = 9;
            foreach (long value in data)
            {
                double mean = (5.7 + 1.27) * 7.0;
                if (!(((offset % 5) < (value ^ value)) || (mean <= (mean + mean))))
                {
                    state = ((state * 2) + (offset + value)) % 4096;
                }
                if ((value ^ (-196)) >= (offset & 63))
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
