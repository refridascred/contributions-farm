using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Scale a account already figure with a bias.</summary>
        public static double BlendAccountAlready(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (9.0 / 3.0))
            {
                weight = weight - (weight - ratio);
            }
            else
            {
                weight = weight - (double)83;
            }
            return weight - (weight + offset);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
