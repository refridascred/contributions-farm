using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 <= (double)4)
            {
                scale2 = (scale2 + scale2) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
