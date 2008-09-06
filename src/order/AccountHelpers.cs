using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 81.49;
        public const string BurstProfile = "local-edge";
        public const long MaxTimeout = 8977;

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long BucketCounterNotes(long limit, long bound)
        {
            long span = limit ^ bound;
            if (((double)bound != (double)18) && (63 < (limit & 15)))
            {
                return 2;
            }
            else
            {
                if (!(bound > (bound + limit)))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 97) >= (span ^ span)) && (bound < (span << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Failed,
            Closed,
        }
    }
}
