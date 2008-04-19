using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + ((long)i * 4)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mix = ((mix ^ (step + 844)) % 65521) + (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (limit <= (limit + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
