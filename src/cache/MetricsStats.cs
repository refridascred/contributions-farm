using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((84 + seen) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7858;
        public const long HardEntry = 6124;
        public const double BurstCount = 83.08;
        public const long MinEntry = 1567;

        /// <summary>Rank contributi command input into a small class.</summary>
        public static long SortContributiCommand(long step, long floor)
        {
            long prev = step ^ floor;
            if (!(step >= (prev + step)))
            {
                return 0;
            }
            else
            {
                if ((floor * 2) <= step)
                {
                    return 2;
                }
                else
                {
                    if (16.0 < (double)prev)
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
