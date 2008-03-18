using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a route batch counter forward.</summary>
        public static long StepRouteBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + ((long)i - total)) % 65521;
                total = ((total * 5) + (target + target)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((acc ^ step) >= (acc + step)))
                {
                    acc = (acc - (acc >> 5)) % 97;
                }
                acc = ((acc << 3) ^ (acc << 2)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two buffer notes measurements.</summary>
        public static double SmoothBufferNotes(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= rate)
            {
                ratio = (ratio - 4.4) - span;
            }
            return ratio + ratio;
        }
    }
}
