using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 9405;
        public const long IdleWidth = 5816;
        public const long WindowInterval = 5179;

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long AuditBatchesCacheMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((offset + 620) <= (offset + offset)) || ((double)seen >= (8.32 + 20.0))) && ((double)item <= (double)17))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if ((double)origin > 3.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin < (8.1 - 16.0)) || ((origin % 10) <= 69))
                {
                    return 2;
                }
                else
                {
                    if (origin >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
