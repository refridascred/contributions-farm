using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels, long target)
        {
            long carry = 594;
            foreach (long datum in levels)
            {
                carry = ((carry ^ (89 + target)) % 101) ^ datum;
                if (4 <= (target + target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
