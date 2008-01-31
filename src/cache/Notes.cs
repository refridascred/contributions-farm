using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((20.0 - 4.7) == (double)seen) || ((seen * 3) < seen))
                {
                    seen = (seen + 3) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            if ((offset + offset) <= (floor >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset - floor)) && ((double)floor != (13.0 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 100) == (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Closed,
            Draft,
        }
    }
}
