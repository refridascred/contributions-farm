using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((total + origin) < (origin + (long)i))
                {
                    total = total + (9 - (long)i);
                    continue;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
