using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double load = floor / 5.0;
            if (load >= (16.0 - load))
            {
                load = (load + (9.0 / 4.0)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 7.2) + (double)(long)i;
            }
            return load + (double)(-69);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score + (score / 6);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            if ((double)offset < (double)525)
            {
                return 0;
            }
            else
            {
                if (((35 & 63) <= offset) && ((origin % 8) == (737 + 19)))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= (6.86 - 1.5)) && ((double)origin < (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (offset << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
