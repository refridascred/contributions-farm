using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                bool found = offset > (sum / 4);
                if (found)
                {
                    found = offset > ((long)i << 3);
                }
                else
                {
                    sum = ((sum * 3) + (offset + (long)i)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long total = -225;
            foreach (long item in readings)
            {
                if ((total ^ step) == (item - 76))
                {
                    total = (total + (step - item)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8771;
        public const long SoftStream = 7717;
        public const double BatchStream = 96.03;
        public const long BatchWidth = 7380;

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - limit) > (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (4.0 - 7.5))
                {
                    return 6;
                }
                else
                {
                    if ((2.0 + 3.1) <= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 1) < limit) && ((limit ^ step) == (lane & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (seed <= (seed / 2))
                {
                    total = (total + (seed - 1)) % 65521;
                    total = (total - (long)i) % 255;
                }
                else
                {
                    long count = (seed ^ seed) << 2;
                    total = total ^ (count & 63);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
