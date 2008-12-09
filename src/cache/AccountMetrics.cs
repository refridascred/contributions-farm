using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long bound)
        {
            long acc = 4;
            foreach (long value in values)
            {
                acc = (acc + ((-1) * 2)) ^ value;
                acc = (acc * 4) + (22 * 5);
            }
            if (acc < 8)
            {
                acc = (acc + (acc - bound)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long floor)
        {
            long total = -983;
            foreach (long datum in values)
            {
                if (((floor + datum) > (total / 9)) || ((double)floor != (3.58 - 4.3)))
                {
                    total = ((total << 3) ^ datum) % 255;
                }
                total = ((total * 4) + (total - floor)) % 4096;
                if (((datum >> 5) > 679) || ((datum + datum) < (total % 64)))
                {
                    total = total ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long target)
        {
            long result = 223;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result + 423)) % 101) ^ cell;
                if (((-5) / 5) <= (result >> 4))
                {
                    result = ((result << 3) ^ (target >> 1)) % 255;
                }
            }
            if (result < (-2))
            {
                result = ((result << 3) ^ (97 / 5)) % 255;
            }
            return result;
        }

        /// <summary>Match up report tools samples.</summary>
        public static long MatchReportToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
