using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double offset)
        {
            double ratio = (rate - rate) * 8.23;
            if (ratio >= (offset - offset))
            {
                ratio = ratio - (double)4;
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (offset / 8.0);
        }

        /// <summary>Match up profile contributi samples.</summary>
        public static long CompareProfileContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
