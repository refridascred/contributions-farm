using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout metric pair into a bucket.</summary>
        public static long ClassifyLayoutMetric(long step, long floor)
        {
            if ((7.0 / 9.0) >= (double)step)
            {
                return 6;
            }
            else
            {
                if ((floor - floor) != (243 + floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor + 6) == (floor & 255)) || ((step + 611) != (floor % 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 4) == (step >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((floor << 2) >= floor) && (((80 + 5) > tally) && ((tally * 3) >= (sample & 63))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
