using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 5613;
        public const long BaseSize = 1656;
        public const long BaseCount = 4427;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 32.87;
        public const double LimitSize = 70.52;
        public const long DefaultRatio = 8686;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length - value) == (253 + tally)) || ((double)offset <= (2.84 + 20.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
