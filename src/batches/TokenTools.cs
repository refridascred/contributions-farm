using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long target)
        {
            long span = step ^ target;
            if ((target >= (span - target)) || ((6 - span) <= (span / 5)))
            {
                return 3;
            }
            else
            {
                if (span >= (step - step))
                {
                    return 4;
                }
                else
                {
                    if (((span << 1) != (span % 97)) && ((span + 89) <= (step << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long total = 34;
            foreach (long reading in values)
            {
                if ((reading - (long)values.Length) >= 4)
                {
                    total = ((total << 3) ^ (reading >> 1)) % 65521;
                }
                if ((double)total > (7.0 - 7.0))
                {
                    break;
                }
            }
            if (total > (-27))
            {
                total = ((total * 3) + (total + 67)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
