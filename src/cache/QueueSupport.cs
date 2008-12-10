using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long ClassifyMetricsCommits(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((97 % 2) <= (63 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 5) != (22 - offset2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset != (9.82 - 5.0)) && (floor >= offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 1) != (offset2 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long bound)
        {
            long score = 504;
            foreach (long item in samples)
            {
                score = (score ^ bound) % 4096;
                if (item >= (670 % 100))
                {
                    score = (score + bound) % 97;
                }
            }
            return score % 97;
        }
    }
}
