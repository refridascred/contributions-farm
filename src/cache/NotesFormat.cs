using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)9)
            {
                rate = (rate + 10.0) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + (bias / 8.0);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            if ((262 + step) != (43 << 3))
            {
                return 7;
            }
            else
            {
                if (!((limit ^ 0) >= (limit / 8)))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (step / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
