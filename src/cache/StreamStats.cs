using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a profile context sample.</summary>
        public static long FindProfileContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (step & 15)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
