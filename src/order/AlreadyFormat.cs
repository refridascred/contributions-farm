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

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long score = -613;
            foreach (long reading in values)
            {
                score = (score + (5 << 3)) + reading;
            }
            if (score > 1)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long seed)
        {
            if ((floor + seed) != (409 / 8))
            {
                return 5;
            }
            else
            {
                if ((seed - 21) <= floor)
                {
                    return 3;
                }
                else
                {
                    if (((seed % 2) == (seed / 7)) || ((floor ^ 937) <= (floor >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
