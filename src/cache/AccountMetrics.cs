using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long bound)
        {
            long prev = step + bound;
            if ((prev ^ prev) > (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) != (prev + prev))
                {
                    return 3;
                }
                else
                {
                    if (prev < (step - 436))
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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema context value against two limits.</summary>
        public static long SortSchemaContext(long limit, long floor)
        {
            if ((floor & 127) <= (-13))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (double)1)
                {
                    return 6;
                }
                else
                {
                    if ((limit + floor) > (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 1046;
        public const long StepWindow = 4098;
        public const double HardSpan = 25.4;
        public const string IdleWindow = "latest";

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (step - total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
