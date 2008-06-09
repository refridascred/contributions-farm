using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next metrics graph value.</summary>
        public static double SmoothMetricsGraph(double weight, double floor)
        {
            double gain = (floor / 9.0) * 9.0;
            return (gain - (gain + floor)) + weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 71.86;
        public const long BurstProfile = 9634;
        public const long BaseSize = 9543;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc ^ (target - 99)) % 101) ^ (long)i2) ^ sample;
                }
                if (target >= acc)
                {
                    acc = (acc ^ (153 << 1)) % 1000;
                }
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ (acc - 9);
            }
            return acc % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally <= (reading + tally)) || (((0 / 4) < reading) && (47 < (reading >> 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long limit)
        {
            long step = floor + limit;
            if (!((step / 4) > (limit >> 5)))
            {
                return 0;
            }
            else
            {
                if (step <= (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ limit) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
