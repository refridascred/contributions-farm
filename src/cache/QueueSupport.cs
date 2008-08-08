using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + result) == (725 + result))
                {
                    result = (result - (long)i) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Ready,
            Done,
            Paused,
        }
    }
}
