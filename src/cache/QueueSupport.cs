using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((3 + limit) >= limit) || ((sum + 71) > (limit ^ limit)))
                {
                    sum = sum + 36;
                    sum = (sum * 5) + (limit & 1);
                }
                sum = sum - (limit / 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a format farm value against two limits.</summary>
        public static long BucketFormatFarm(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((limit2 >> 3) >= limit)
            {
                return 3;
            }
            else
            {
                if (((limit & 127) != (9 + limit)) && ((double)prev > 4.3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
