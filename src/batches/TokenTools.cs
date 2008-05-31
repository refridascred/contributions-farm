using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load > (load + 16.0))
            {
                load = (load + (double)660) - floor;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (scale * 7.0);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                if ((carry < (carry * 4)) && (reading < ((-79) + carry)))
                {
                    carry = (carry * 4) + (reading - reading);
                }
            }
            if (carry < 21)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
