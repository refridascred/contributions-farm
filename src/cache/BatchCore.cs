using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long step)
        {
            long mix = 124;
            foreach (long item in data)
            {
                if ((811 % 5) >= mix)
                {
                    mix = (mix + (step * 5)) ^ item;
                    continue;
                }
                if ((double)mix <= 18.0)
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (step / 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Closed,
            Active,
            Pending,
        }
    }
}
