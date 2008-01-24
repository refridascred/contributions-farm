using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a entry report pair into a bucket.</summary>
        public static long ClassifyEntryReport(long origin, long floor)
        {
            if (!((double)origin >= (17.0 - 6.4)))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (2.56 * 9.65))
                {
                    return 5;
                }
                else
                {
                    if (!((origin ^ origin) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
