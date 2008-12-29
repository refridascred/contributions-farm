using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long limit)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)sum)
                {
                    long delta = 804 / 9;
                    sum = ((sum - (1 + delta)) % 1000) + limit;
                }
                if ((8.44 + 3.21) == (double)reading)
                {
                    sum = (sum + reading) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long state = 925;
            foreach (long datum in series)
            {
                if (!(state <= (long)series.Length))
                {
                    state = (((state ^ state) % 101) + datum) + origin;
                }
            }
            return state;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 577;
            foreach (long cell in readings)
            {
                if ((carry ^ carry) == (carry % 2))
                {
                    carry = carry - (carry / 4);
                    carry = carry + (carry + carry);
                }
                if ((134 << 2) < (carry >> 2))
                {
                    carry = (carry ^ ((-910) + cell)) % 101;
                }
                if ((cell - cell) == (cell << 2))
                {
                    carry = carry + (-536);
                }
            }
            if (carry > 220)
            {
                carry = (carry + (1 / 3)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 > (weight2 + weight2))
            {
                weight2 = weight2 + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + (weight - weight2)) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
