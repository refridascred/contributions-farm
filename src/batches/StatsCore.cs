using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session stats readings against a rule.</summary>
        public static long MeasureSessionStatsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((5.9 + 3.0) < (double)seen)
                {
                    seen = ((seen + 2) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 289;
            foreach (long value in data)
            {
                if ((value >> 3) < carry)
                {
                    carry = ((carry << 3) ^ (carry - 12)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((offset & 63) < matches) || ((double)6 == (double)matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
