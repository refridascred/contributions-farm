using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long OverlapClusterReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series)
        {
            long result = -45;
            foreach (long entry in series)
            {
                if ((result ^ (long)series.Length) == (result + result))
                {
                    result = result + (entry / 7);
                }
            }
            if (result < 26)
            {
                result = ((result * 5) + (result - 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Project the next account window value.</summary>
        public static double AdjustAccountWindow(double bias, double bias2)
        {
            double scale = (1.5 - bias) + (bias + 9.0);
            if (scale > (double)2)
            {
                scale = (scale - (double)893) - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (scale + scale);
        }
    }
}
