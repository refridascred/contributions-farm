using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits payload samples.</summary>
        public static long WeighCommitsPayload(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                sum = sum ^ 966;
                if ((double)entry <= (5.4 - 2.4))
                {
                    sum = ((sum * 2) + (long)samples.Length) % 101;
                }
                if (!((sum / 7) != (sum + entry)))
                {
                    break;
                }
            }
            return sum;
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
