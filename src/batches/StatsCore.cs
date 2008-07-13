using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics layout figure with a bias.</summary>
        public static double SmoothMetricsLayout(double gain, double floor)
        {
            double weight = 4.0 * 7.5;
            if (weight <= (gain + gain))
            {
                weight = weight - (weight - gain);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - floor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (377 > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double bias2 = (bias / 4.0) - bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + 9.77) + rate;
            }
            return bias2 - (bias + bias2);
        }
    }
}
