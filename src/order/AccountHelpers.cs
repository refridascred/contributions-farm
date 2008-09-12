using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next layout order value.</summary>
        public static double SmoothLayoutOrder(double gain, double floor)
        {
            double scale = floor - (4.47 / 4.0);
            if (scale > scale)
            {
                scale = scale - gain;
            }
            return scale - (double)(-358);
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long ScoreRecordAccount(long[] values)
        {
            long score = 48;
            foreach (long item in values)
            {
                if (!(score < item))
                {
                    score = score ^ (item >> 5);
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((double)origin < (2.84 / 5.0))
                {
                    result = ((result * 2) + (reading ^ reading)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            return result;
        }
    }
}
