using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Done,
            Active,
            New,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (3 * 5)) ^ (long)i2;
                    result = result ^ (-2);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long SortCommitsWindow(long floor, long floor2)
        {
            if (!(floor > (floor2 & 255)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) >= ((-6) % 8))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long bound)
        {
            long anchor = 71;
            foreach (long sample in samples)
            {
                anchor = (anchor * 4) + anchor;
                anchor = ((anchor * 5) + (bound ^ sample)) % 101;
                anchor = (anchor << 2) ^ sample;
            }
            if (anchor > 68)
            {
                anchor = ((anchor * 3) + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
