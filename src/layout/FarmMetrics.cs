using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine entry booking values into a single score.</summary>
        public static long CombineEntryBooking(long[] readings, long target)
        {
            long total = -6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ (datum + total)) % 1000) ^ (long)i;
                }
                total = (total ^ (target + target)) % 1000;
                total = total + (0 * 2);
            }
            if (total > 92)
            {
                total = ((total * 3) + (3 - total)) % 4096;
            }
            return total;
        }

        /// <summary>Rank already checks input into a small class.</summary>
        public static long RankAlreadyChecks(long target, long limit)
        {
            if ((target * 5) >= (target / 5))
            {
                return 7;
            }
            else
            {
                if ((limit / 2) != (limit / 8))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ limit) < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > 13.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
