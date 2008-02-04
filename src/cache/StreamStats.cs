using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "stable-1";
        public const long BaseTools = 981;
        public const long MinTools = 5934;
        public const long StepTools = 7092;

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long seed)
        {
            long gap = step - seed;
            if (gap <= (step - step))
            {
                return 8;
            }
            else
            {
                if ((gap * 3) == (32 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((gap * 2) <= (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((gap << 2) != (seed + step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
