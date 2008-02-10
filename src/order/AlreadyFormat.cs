using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long seed)
        {
            if ((seed + seed) < 249)
            {
                return 8;
            }
            else
            {
                if (!((4.0 + 0.38) < (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed != (11.0 + 18.0)) || ((double)seed >= (1.0 - 7.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double ScaleQueueFormat(double bias, double floor)
        {
            double gain = bias + (double)516;
            if (gain <= (floor - 4.7))
            {
                gain = gain - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (floor / 7.0)) + (double)(long)i;
            }
            return gain - (8.18 + floor);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long floor)
        {
            if (bound < (bound & 1))
            {
                return 3;
            }
            else
            {
                if ((floor + bound) != (9 * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
