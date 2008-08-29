using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long MeasureStreamFarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) <= floor)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long step)
        {
            long sum = 418;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (step + value);
                if (!!((double)step != (6.2 - 5.8)))
                {
                    sum = (sum << 2) ^ (step / 2);
                }
                if (459 > value)
                {
                    sum = ((sum << 3) ^ (step - 7)) % 255;
                }
                else
                {
                    sum = (sum ^ (step / 2)) % 101;
                }
                if ((sum % 12) < (value << 3))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
