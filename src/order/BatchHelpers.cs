using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                if ((cell - total) <= (cell % 24))
                {
                    total = (total ^ (total + 74)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (4 + total);
                }
                total = (total << 2) ^ (total + cell);
                if ((total - 6) < cell)
                {
                    total = total ^ (cell << 2);
                }
                else
                {
                    total = (total + (cell - total)) % 255;
                }
            }
            if (total < 215)
            {
                total = total + ((long)samples.Length + total);
            }
            return total;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((37 + sample) == ((long)readings.Length % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
