using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long FindGithubfarmContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = bias / 3.0;
            if (ratio <= bias)
            {
                ratio = ratio + (double)65;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 0.6) + (double)(long)i;
            }
            return ratio + (rate + bias);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long target)
        {
            long bound = step ^ target;
            if (step < (49 + step))
            {
                return 2;
            }
            else
            {
                if ((bound >> 4) >= ((-68) >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ target) <= (73 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)target < (1.4 * 9.0)))
                        {
                            return 6;
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
