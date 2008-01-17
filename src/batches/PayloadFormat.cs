using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (step - acc)) % 4096;
                acc = acc + (acc << 2);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if ((9 - (long)i) >= ((long)i ^ step))
                {
                    total = (total - ((long)i + total)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long origin)
        {
            if ((origin / 2) > (offset + origin))
            {
                return 1;
            }
            else
            {
                if (((147 / 3) == (offset >> 5)) || ((origin + offset) < (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits + datum) >= (hits ^ seed)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
