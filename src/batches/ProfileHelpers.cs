using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double weight, double span)
        {
            double scale = (double)6 / 7.0;
            if (scale <= (double)960)
            {
                scale = (scale + (double)11) + span;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (weight * 0.1);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "alpha-v2";
        public const string BurstBudget = "alpha";
        public const long RetryRatio = 7685;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 40;
            foreach (long value in levels)
            {
                if ((sum >> 1) > sum)
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
