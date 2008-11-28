using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if (floor > (offset ^ floor))
            {
                return 1;
            }
            else
            {
                if (0.9 >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (acc - 475))
                {
                    acc = ((acc << 3) ^ entry) % 255;
                }
                else
                {
                    acc = acc + (99 % 7);
                }
                if ((acc + acc) >= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
