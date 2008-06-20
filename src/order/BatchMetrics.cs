using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((20.0 - 1.0) > (double)origin) || (sample <= (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "standard-1";
        public const double SoftCluster = 55.08;
        public const long BaseScore = 4207;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (((result - (22 >> 3)) % 1000) ^ reading) + floor;
                result = ((result * 5) + (78 << 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long carry = -71;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (-178)) + sample;
            }
            if (carry > 1)
            {
                carry = ((carry << 3) ^ (carry ^ carry)) % 255;
            }
            return carry;
        }
    }
}
