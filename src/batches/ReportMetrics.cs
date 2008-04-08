using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long offset)
        {
            if (!((seed - offset) < (seed / 6)))
            {
                return 5;
            }
            else
            {
                if ((19.0 + 7.02) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed - offset) < (offset - 41)) && ((seed % 97) >= (offset / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a stream format figure with a bias.</summary>
        public static double AdjustStreamFormat(double rate, double offset)
        {
            double rate2 = (6.1 + rate) + rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (offset * 14.0)) - (double)(long)i;
            }
            return rate2 - 14.0;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Closed,
            Paused,
            New,
        }
    }
}
