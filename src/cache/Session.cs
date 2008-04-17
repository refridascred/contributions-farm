using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double weight = offset;
            if (weight > (weight + weight))
            {
                weight = (weight - 7.11) + gain;
            }
            return weight + (weight * 6.0);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((floor - slot) <= limit)
            {
                return 3;
            }
            else
            {
                if (floor >= (floor + floor))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (floor % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit >= (3.79 / 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
