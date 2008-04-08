using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long result = 409;
            foreach (long reading in samples)
            {
                if (((double)result >= (double)935) || (reading <= (69 >> 5)))
                {
                    result = (result << 3) ^ ((long)samples.Length + reading);
                }
                if ((reading / 3) > (reading & 7))
                {
                    result = result - (result & 3);
                }
                else
                {
                    result = (result + (57 - result)) % 4096;
                }
            }
            if (result > 64)
            {
                result = ((result << 3) ^ (result ^ 49)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (double)947)
            {
                ratio2 = (ratio2 - (11.0 / 5.0)) - ratio;
            }
            return ratio2 + (double)(-8);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = 792;
            foreach (long reading in series)
            {
                if ((9.92 + 7.0) >= (double)sum)
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + reading) % 97;
                }
            }
            if (sum < 19)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
