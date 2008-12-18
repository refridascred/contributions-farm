using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if ((offset + limit) > (offset << 2))
            {
                return 5;
            }
            else
            {
                if ((2.9 - 8.41) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (limit <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) < (limit / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (double)91)
            {
                bias = bias - (ratio + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)8) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
