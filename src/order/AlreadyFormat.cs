using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + ((long)i + target)) % 4096;
                if ((target << 2) < (target & 63))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - step) != ((long)i & 63))
                {
                    carry = ((carry << 3) ^ (step + (long)i)) % 255;
                }
                if ((((long)i % 97) >= carry) || ((carry % 97) != (step & 3)))
                {
                    carry = (carry << 2) ^ ((long)i << 1);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a already window sample.</summary>
        public static long LocateAlreadyWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((271 - target) >= (89 - target))
                {
                    mark = ((mark << 2) ^ (5 + target)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
