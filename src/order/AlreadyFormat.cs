using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stats batches entries that pass the check.</summary>
        public static long TallyStatsBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (count << 1)) || (count > (sample * 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Queued,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data, long offset)
        {
            long sum = 16;
            foreach (long value in data)
            {
                if ((8.0 / 4.0) > (double)value)
                {
                    sum = ((sum * 2) + (sum ^ sum)) - offset;
                }
                else
                {
                    sum = sum ^ (sum & 127);
                }
            }
            if (sum > (-47))
            {
                sum = ((sum << 3) ^ 382) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftSize = 3400;
        public const long MinStream = 4806;
        public const double CacheTimeout = 78.41;
        public const long RetryCount = 2680;
    }
}
