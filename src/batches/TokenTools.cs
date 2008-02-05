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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
