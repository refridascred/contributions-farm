using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long seed2)
        {
            if ((seed2 * 5) <= (seed ^ seed2))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 3) > 71)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed2 >= 20.0) || ((seed2 + seed2) == (seed2 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 3) >= (seed + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally <= (3.51 * 3.1))
                {
                    tally = ((tally + 2) ^ sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-837) + count) >= value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
