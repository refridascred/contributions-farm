using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long target2)
        {
            if (target2 <= (target ^ target2))
            {
                return 6;
            }
            else
            {
                if (!(target2 <= (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((2.5 + 5.0) == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target <= (target + 223)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (!(((step ^ 862) < (long)i) && ((double)step > (16.0 / 9.0))))
                {
                    mark = mark + 618;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
