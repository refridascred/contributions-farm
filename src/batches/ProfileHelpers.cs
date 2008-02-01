using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long bound)
        {
            long anchor = 38;
            foreach (long sample in items)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) - bound;
                if ((double)sample > (11.0 - 2.0))
                {
                    anchor = anchor + (anchor - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes record sample.</summary>
        public static long FindNotesRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
