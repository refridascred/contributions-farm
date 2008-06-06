using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= rate)
            {
                bias2 = bias2 - 7.17;
            }
            else
            {
                bias2 = bias2 + (bias - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (double)428;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long seed)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                carry = ((carry - (962 + seed)) % 97) + reading;
            }
            if (carry < 3)
            {
                carry = (carry ^ (seed + 782)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
