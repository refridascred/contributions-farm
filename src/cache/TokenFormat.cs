using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long bound)
        {
            if (!((limit + (-56)) <= (bound - 720)))
            {
                return 4;
            }
            else
            {
                if ((limit >> 4) < limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = offset * 8.72;
            if (gain >= (double)88)
            {
                gain = (gain + 9.0) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + 13.0;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Synced,
            Closed,
        }
    }
}
