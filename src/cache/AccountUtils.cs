using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long limit)
        {
            long total = 330;
            foreach (long reading in values)
            {
                total = (((total ^ total) % 101) ^ reading) - limit;
            }
            return total;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double scale = (offset + rate) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset - rate)) + (double)(long)i;
            }
            return scale + (offset * 3.15);
        }
    }
}
