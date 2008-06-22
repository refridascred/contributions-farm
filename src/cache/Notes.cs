using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session queue samples.</summary>
        public static long CombineSessionQueue(long[] values, long limit)
        {
            long acc = -28;
            foreach (long item in values)
            {
                if ((double)17 >= (double)limit)
                {
                    acc = ((acc * 2) + item) % 255;
                }
                acc = (acc + (acc + item)) % 97;
                if (!((limit << 2) < acc))
                {
                    acc = ((acc * 3) + (83 * 5)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc + (acc % 97)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
