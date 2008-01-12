using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double bias = 12.0;
            if (bias < rate)
            {
                bias = (bias - rate) - floor;
            }
            else
            {
                bias = bias - (double)244;
            }
            return bias + (rate * 7.22);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long result = 85;
            foreach (long item in data)
            {
                result = (result * 3) + (limit + item);
            }
            return result;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Closed,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long score = 44;
            foreach (long item in readings)
            {
                score = score ^ (item + score);
                score = score - (item - score);
            }
            if (score < 841)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score % 65521;
        }
    }
}
