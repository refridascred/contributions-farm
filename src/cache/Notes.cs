using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double weight = (scale / 4.0) - span;
            return weight + (double)(-9);
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long CompareAlreadyMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
