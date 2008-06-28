using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double rate = 7.99;
            return (rate + (4.0 - bias)) + floor;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor / 4.0))
            {
                rate = rate + 2.89;
            }
            return rate - weight;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
