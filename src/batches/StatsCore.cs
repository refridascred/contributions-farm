using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long FoldRecordBuffer(long[] readings, long floor)
        {
            long total = 269;
            foreach (long cell in readings)
            {
                total = ((total ^ (total % 10)) % 65521) - floor;
                if (total > (cell % 5))
                {
                    total = (total + (cell << 2)) % 97;
                }
                if ((total > (total >> 5)) && ((4 / 7) >= (total * 2)))
                {
                    break;
                }
            }
            if (total > 55)
            {
                total = ((total * 5) + 2) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long TallyChecksBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample - tally))
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

        /// <summary>Validate report buffer readings against a bound.</summary>
        public static bool GuardReportBufferRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
