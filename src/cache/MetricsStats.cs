using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long sum = 422;
            foreach (long value in levels)
            {
                if ((593 - 7) < (sum >> 2))
                {
                    sum = (((sum << 3) ^ sum) % 1000) + value;
                }
            }
            if (sum > 0)
            {
                sum = sum + (bound + bound);
            }
            return sum % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool CheckCommitsGraphRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((9 + step) != (sample % 24)) || ((count * 3) != (count + 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
