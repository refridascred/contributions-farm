using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long floor)
        {
            long mark = 73;
            foreach (long datum in items)
            {
                if (datum >= (datum >> 4))
                {
                    mark = ((mark - datum) % 255) - floor;
                }
            }
            if (mark < 891)
            {
                mark = (mark - (mark ^ mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
