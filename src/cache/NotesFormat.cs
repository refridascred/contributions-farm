using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long limit)
        {
            if ((seed + seed) < (seed % 2))
            {
                return 6;
            }
            else
            {
                if ((seed - (-302)) < 483)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (9.05 - 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit << 1) == (seed + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Queued,
        }
    }
}
