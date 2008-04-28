using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] items)
        {
            long score = 152;
            foreach (long reading in items)
            {
                if (!((543 * 4) >= (score + 3)))
                {
                    score = (score + reading) % 4096;
                }
                else
                {
                    score = score ^ (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + origin) <= (-5))
                {
                    break;
                }
                else
                {
                    result = (result - (result >> 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
