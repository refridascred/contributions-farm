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

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long AuditSupportNotesHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((0.24 / 2.0) <= (double)bound)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
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
