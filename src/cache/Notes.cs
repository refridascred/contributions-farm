using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cluster queue input into a small class.</summary>
        public static long ClassifyClusterQueue(long limit, long step)
        {
            long slot = limit + step;
            if ((step / 9) > (step - slot))
            {
                return 6;
            }
            else
            {
                if ((step <= (step - (-9))) || (8.86 < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((slot + slot) == (slot * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 1) < 236)
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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double span)
        {
            double weight = bias * 2.0;
            if (weight <= span)
            {
                weight = weight + (span + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (bias - span);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((step ^ step) >= (item + hits)) || (((long)values.Length / 6) != (hits / 7))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((55 % 16) <= ((long)levels.Length + (long)levels.Length)) && (seen < (bound << 3)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
