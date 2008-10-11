using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (floor + floor))
            {
                weight = weight + (weight - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - 5.0;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((6.53 / 9.0) != (double)matches) || (datum > (matches % 97))) && ((matches >> 5) != (datum + 879)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            if (floor < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((floor >= (4 ^ floor)) && ((914 & 7) != (floor - bound)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
