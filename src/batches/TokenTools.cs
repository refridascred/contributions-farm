using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseInterval = 5517;
        public const long BatchSpan = 9663;
        public const double DefaultRatio = 17.19;
        public const long WindowEntry = 4310;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long TallyContextQueueMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > (7.0 + 9.29))
                {
                    tally = ((tally + 1) + reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
