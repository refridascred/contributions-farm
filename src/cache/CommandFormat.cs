using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = (mix * 2) + (mix ^ cell);
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
