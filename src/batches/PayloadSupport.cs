using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long mix = -1;
            foreach (long value in data)
            {
                if ((995 + value) <= (mix % 16))
                {
                    mix = mix + (mix / 3);
                }
                else
                {
                    mix = (mix ^ (mix >> 1)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix * 5) + (3 + mix);
            }
            return mix;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Stale,
            Queued,
            Paused,
        }
    }
}
