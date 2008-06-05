using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long total = 539;
            foreach (long reading in readings)
            {
                if (!((3.8 + 8.5) < (double)total))
                {
                    total = ((total << 2) ^ (reading + total)) % 101;
                }
                total = ((total * 5) + (total + total)) % 65521;
                total = (total * 5) + (reading * 5);
                if (!((long)readings.Length > (bound / 5)))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (37 >> 2);
            }
            return total;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a stream report pair into a bucket.</summary>
        public static long GradeStreamReport(long limit, long target)
        {
            long next = limit - target;
            if (((next & 7) != (target << 2)) || ((target - limit) != (limit & 31)))
            {
                return 1;
            }
            else
            {
                if ((target - 2) < (limit / 5))
                {
                    return 5;
                }
                else
                {
                    if (((double)884 >= (double)target) || ((limit + target) > (417 >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
