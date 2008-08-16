using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a route channel counter forward.</summary>
        public static long RollRouteChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + (70 + sum)) % 65521) - (long)i2;
                    sum = (sum ^ (offset + 91)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count << 3) <= count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Queued,
            New,
            Active,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long floor)
        {
            long prev = step - floor;
            if ((89 >> 3) != (prev + step))
            {
                return 1;
            }
            else
            {
                if (((prev + prev) > (step + step)) || ((floor ^ step) > (floor & 3)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
