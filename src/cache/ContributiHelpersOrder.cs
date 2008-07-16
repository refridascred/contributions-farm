using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TallyCounterBuffer(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((bound - bound) == (bound >> 4))
                {
                    anchor = anchor - value;
                }
                if (anchor > (65 + 92))
                {
                    anchor = (anchor + (bound * 3)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (bound << 3);
                }
                if ((bound ^ anchor) <= (anchor + bound))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (bound ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
