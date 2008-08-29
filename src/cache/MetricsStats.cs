using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((0 & 31) < reading) || ((count << 1) < (35 & 63))) && ((reading ^ count) <= reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long limit)
        {
            long diff = step ^ limit;
            if ((step + diff) <= (limit ^ diff))
            {
                return 4;
            }
            else
            {
                if (((diff - diff) >= (step + step)) && ((step << 1) != (limit * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
