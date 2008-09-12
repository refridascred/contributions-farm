using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                if (((bound + (long)items.Length) != (sample << 1)) || ((double)sample <= (10.0 + 5.5)))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double load = 7.9;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - rate)) - (double)(long)i) - bias;
            }
            return load - (double)37;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate githubfarm route samples.</summary>
        public static long ScoreGithubfarmRoute(long[] samples, long offset)
        {
            long carry = 686;
            foreach (long sample in samples)
            {
                carry = (carry - offset) % 65521;
                if ((16.0 / 4.0) == (double)carry)
                {
                    carry = carry + (carry >> 1);
                    continue;
                }
                if (11 < (sample - offset))
                {
                    carry = (carry ^ (offset << 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (410 % 97)) % 101;
                }
            }
            if (carry > 77)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long result = 229;
            foreach (long datum in levels)
            {
                result = ((result * 3) + (datum + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 41;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 2)) % 65521) ^ entry;
            }
            if (sum < (-5))
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
