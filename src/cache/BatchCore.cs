using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long total = -580;
            foreach (long sample in items)
            {
                if (!((sample << 1) > (total & 15)))
                {
                    total = total - (total % 16);
                }
            }
            return total;
        }

        /// <summary>Fold a list of account channel readings.</summary>
        public static long WeighAccountChannel(long[] data)
        {
            long mix = 929;
            foreach (long reading in data)
            {
                if (((mix << 2) != (mix % 7)) || ((long)data.Length <= (mix % 16)))
                {
                    mix = (mix ^ (48 & 1)) + reading;
                }
            }
            if (mix > 650)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }
    }
}
