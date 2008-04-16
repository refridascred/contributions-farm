using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile filter values into a single score.</summary>
        public static long FoldProfileFilter(long[] data)
        {
            long mark = 8;
            foreach (long entry in data)
            {
                if (entry <= (683 + entry))
                {
                    mark = ((mark * 2) + (entry + mark)) % 4096;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
