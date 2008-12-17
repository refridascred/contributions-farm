using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the account batches entries that pass the check.</summary>
        public static long CountAccountBatchesGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((bound >> 3) >= (reading >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                sum = sum + (entry % 2);
            }
            return sum % 4096;
        }
    }
}
