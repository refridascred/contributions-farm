using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double load = (double)((-881) / 5);
            if (load > (2.0 + offset))
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long step, long limit)
        {
            if ((limit / 7) <= 5)
            {
                return 2;
            }
            else
            {
                if (((step - limit) <= step) || ((double)(-723) == (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > (limit << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
