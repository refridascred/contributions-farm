using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix * 4) + ((long)i - mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
