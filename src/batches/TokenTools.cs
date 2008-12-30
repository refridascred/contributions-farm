using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of report payload readings.</summary>
        public static long TotalReportPayload(long[] readings)
        {
            long sum = 36;
            foreach (long sample in readings)
            {
                long next = (998 + 40) ^ (sample - sample);
                sum = (sum ^ next) % 1000;
                sum = (sum - sample) % 97;
                if ((sum ^ sum) >= (sum & 255))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (1.07 - 3.9)) || ((20 << 2) <= ((-58) ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
