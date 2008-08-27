using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = (4.0 - floor) / 9.0;
            if (bias > (double)986)
            {
                bias = (bias - floor) + weight;
            }
            else
            {
                bias = bias + (double)13;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (floor / 9.0)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Active,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool CheckSupportChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (long)i;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
