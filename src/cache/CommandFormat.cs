using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long seed)
        {
            long diff = origin - seed;
            if ((origin - diff) > (origin * 2))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (diff + seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) > 43)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (double)7)
            {
                bias2 = bias2 + (double)106;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - 5.85) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
