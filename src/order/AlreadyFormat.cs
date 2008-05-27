using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 20.97;
        public const double SoftScore = 93.9;
        public const long StepCount = 5694;
        public const long IdleOrder = 3440;
        public const long MinWidth = 5952;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count ^ count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LocateBatchesContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool CheckEntryWindowBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
