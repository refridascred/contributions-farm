using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long origin)
        {
            long offset = target + origin;
            if ((double)offset > 3.1)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (20.0 * 6.3))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
