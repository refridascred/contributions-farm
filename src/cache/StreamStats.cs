using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 17;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((double)cell >= 0.3)
                {
                    sum = (sum - 872) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (7 + 88)) % 97;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long total = 41;
            foreach (long datum in levels)
            {
                if (datum >= 577)
                {
                    total = total ^ (datum - datum);
                }
            }
            if (total > 90)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            if (!(floor < 9))
            {
                return 2;
            }
            else
            {
                if (!((42 % 12) <= origin))
                {
                    return 8;
                }
                else
                {
                    if (origin <= (floor - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((92 >> 5) <= (origin << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
