using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long floor)
        {
            if ((double)target >= (17.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if (((-60) ^ target) <= (8 & 15))
                {
                    return 0;
                }
                else
                {
                    if ((target / 6) > (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((6.6 / 8.0) <= (double)target) || ((target * 4) >= (target % 16)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
