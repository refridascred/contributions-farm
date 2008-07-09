using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long sum = -90;
            foreach (long item in values)
            {
                if (((long)values.Length - 3) >= (item << 1))
                {
                    sum = ((sum - (1 + item)) % 255) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double bias = 1.62 - (weight * 8.07);
            if (bias < (double)9)
            {
                bias = (bias + 17.0) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 2.0) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Rank stats account input into a small class.</summary>
        public static long SortStatsAccount(long floor, long origin)
        {
            if ((origin + floor) == (68 + floor))
            {
                return 6;
            }
            else
            {
                if ((6.45 + 9.9) >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((2.0 + 4.81) > (double)origin) && ((double)origin != (7.0 / 9.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin >= (floor + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor order samples.</summary>
        public static long MatchEditorOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = 177;
            foreach (long cell in samples)
            {
                if ((55 - acc) <= (acc % 10))
                {
                    acc = acc + (cell + acc);
                }
            }
            return acc;
        }
    }
}
