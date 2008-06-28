using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metrics filter series from a seed.</summary>
        public static long DeriveMetricsFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result + (floor & 15);
                result = result - floor;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank contributi editor input into a small class.</summary>
        public static long GradeContributiEditor(long step, long limit)
        {
            long step2 = step ^ limit;
            if ((limit + limit) < (step & 127))
            {
                return 1;
            }
            else
            {
                if ((step2 & 1) < step)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > 4.9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
