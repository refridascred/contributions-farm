using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            return (mean + (bias - bias)) + bias2;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(615 >= step) && !(step <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = (rate + floor) + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)28) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry - (carry ^ limit)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
