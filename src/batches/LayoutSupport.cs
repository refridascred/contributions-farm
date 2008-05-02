using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long sum = 2;
            foreach (long cell in data)
            {
                sum = (sum * 3) + (cell + cell);
                if (!((sum + cell) > sum))
                {
                    sum = (sum ^ cell) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                long next = acc;
                long next2 = next;
                if (!((acc ^ next2) > (next2 % 60)))
                {
                    long tally = 4 << 2;
                    acc = ((acc << 3) ^ (tally + next)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
