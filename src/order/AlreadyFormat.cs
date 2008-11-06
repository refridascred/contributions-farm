using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a profile payload pair into a bucket.</summary>
        public static long BucketProfilePayload(long bound, long step)
        {
            long cur = bound ^ step;
            if ((66 >= cur) && ((bound + step) >= (step - cur)))
            {
                return 8;
            }
            else
            {
                if ((step % 12) >= cur)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Idle,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstBudget = 2102;
        public const string WindowLevel = "latest-v2";
        public const long BaseSize = 5191;
        public const double MinLevel = 97.89;
        public const double LimitWidth = 98.38;

        /// <summary>Look up the position of a batch contributi sample.</summary>
        public static long SeekBatchContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples)
        {
            long total = 73;
            foreach (long reading in samples)
            {
                total = (total - (reading / 7)) % 255;
                if ((double)reading > (15.0 - 6.2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
