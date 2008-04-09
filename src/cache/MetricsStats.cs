using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long WeighCounterCluster(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (34 >= (total + datum))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                else
                {
                    total = total + (total >> 1);
                }
            }
            if (total > (-2))
            {
                total = total ^ (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Classify a command report pair into a bucket.</summary>
        public static long SortCommandReport(long origin, long step)
        {
            long cur = origin + step;
            if ((9.7 - 3.0) < (double)cur)
            {
                return 6;
            }
            else
            {
                if ((origin * 5) >= step)
                {
                    return 1;
                }
                else
                {
                    if (cur > (step << 1))
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (7 & 63))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((0 ^ value) >= (matches + matches)) && ((double)value == (1.6 + 8.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
