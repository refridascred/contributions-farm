using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account channel readings against a rule.</summary>
        public static long CountAccountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (double)156)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long step)
        {
            if (seed >= (step & 127))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (4.0 + 6.94))
                {
                    return 0;
                }
                else
                {
                    if ((2.5 >= (double)seed) && ((double)seed == (3.5 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 31) > (seed + (-282)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
