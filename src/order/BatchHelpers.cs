using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double ratio2 = (ratio / 3.0) + (ratio * 7.5);
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + floor;
            }
            else
            {
                ratio2 = ratio2 - (double)30;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio2 / 6.0);
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value + seen) < seen) || (seen >= (95 ^ value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
