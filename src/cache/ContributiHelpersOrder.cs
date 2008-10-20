using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
