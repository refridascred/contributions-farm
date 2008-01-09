using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long sum = 763;
            foreach (long datum in readings)
            {
                if (!(datum < ((-353) << 3)))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum - (85 - datum);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 503;
            foreach (long reading in items)
            {
                if ((reading + 59) == (state << 1))
                {
                    state = (state - (state / 5)) % 1000;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 2) <= matches) && ((743 + reading) != (reading << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long step2)
        {
            if (step2 < (step2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((8.25 / 2.0) >= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
