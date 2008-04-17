using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((4.0 + 5.79) != (double)offset) && ((515 + result) < result))
                {
                    result = (result + (offset & 1)) % 101;
                    result = (result + 334) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepInterval = 49.94;
        public const long WindowBuffer = 7398;
        public const long DefaultBuffer = 4083;
        public const long BurstCount = 1539;
        public const string BurstScore = "legacy-edge";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long origin)
        {
            long step = bound ^ origin;
            if (!((944 / 3) >= (origin >> 5)))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((origin + 816) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (origin >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
