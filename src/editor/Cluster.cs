using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
