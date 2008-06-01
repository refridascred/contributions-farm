using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
