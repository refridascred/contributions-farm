using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long limit)
        {
            long anchor = 287;
            foreach (long cell in readings)
            {
                if (!((2.2 / 6.0) != (double)limit))
                {
                    anchor = ((anchor * 2) + 86) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + (cell + anchor)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target == (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
