using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long bound)
        {
            if (((6 % 5) < bound) || ((double)bound > (1.35 + 15.0)))
            {
                return 4;
            }
            else
            {
                if ((3.0 - 6.59) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor + 3) == (floor - floor))
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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double load = 8.68;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - span) + (double)(long)i) + bias;
            }
            return load - (span + 5.01);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long GradeContributiAlready(long target, long step)
        {
            if (!((step + step) >= (step / 6)))
            {
                return 2;
            }
            else
            {
                if (!((37 + step) < (452 / 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
