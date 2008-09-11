using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long origin)
        {
            long anchor = 70;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (anchor * 2)) % 101) + sample;
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (anchor + origin)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (seed - seed)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long origin)
        {
            if (((67 - origin) > limit) && (origin >= (4 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) >= (origin % 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
