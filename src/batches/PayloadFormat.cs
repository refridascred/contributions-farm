using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate route context samples.</summary>
        public static long WeighRouteContext(long[] data)
        {
            long mix = 22;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (99 - item)) % 65521;
            }
            if (mix < 87)
            {
                mix = ((mix * 4) + ((long)data.Length + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (ratio - 1.22))
            {
                drift = drift - (double)99;
            }
            else
            {
                drift = drift + floor;
            }
            return drift + 10.0;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
