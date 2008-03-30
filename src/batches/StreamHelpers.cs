using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next queue tools value from a seed.</summary>
        public static long StepQueueTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (817 / 4)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((limit2 <= (limit2 >> 5)) || ((limit2 + limit) > (0 + 879)))
            {
                return 2;
            }
            else
            {
                if (limit2 >= limit)
                {
                    return 3;
                }
                else
                {
                    if ((120 + limit2) < (limit2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((step % 97) < count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
