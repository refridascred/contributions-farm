using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long limit)
        {
            long span = floor - limit;
            if ((24 <= (span + floor)) || ((span - span) != (limit + span)))
            {
                return 7;
            }
            else
            {
                if (((double)limit <= (8.15 - 15.0)) && (7.95 > (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 2) <= (3 >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((80 << 3) != (limit & 63)) && ((637 ^ floor) < (floor ^ (-405))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long AuditSupportEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count * 4) != (count / 3))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
