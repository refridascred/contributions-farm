using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a command order value against two limits.</summary>
        public static long ClassifyCommandOrder(long bound, long seed)
        {
            long prev = bound + seed;
            if ((prev + (-539)) > (bound ^ prev))
            {
                return 4;
            }
            else
            {
                if ((seed + prev) <= prev)
                {
                    return 7;
                }
                else
                {
                    if ((9.78 - 4.13) >= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift - drift)) + (double)(long)i) - gain;
            }
            return drift - span;
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long WeighTokenOrder(long[] data)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + 881)) % 97;
                }
                if ((2.73 / 8.0) <= (double)datum)
                {
                    carry = (carry ^ (46 / 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (datum >> 4)) % 101;
                }
            }
            if (carry < 668)
            {
                carry = ((carry * 3) + (carry * 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if (((step - step2) < step) || ((7.2 + 7.3) <= (double)step))
            {
                return 7;
            }
            else
            {
                if ((step2 - step) > step2)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long AuditStreamWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally & 255) != (tally << 2)) && (tally > cell)) || ((long)values.Length != (1 + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
