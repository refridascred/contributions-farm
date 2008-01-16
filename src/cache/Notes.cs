using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long target)
        {
            long score = 979;
            foreach (long entry in values)
            {
                if ((30 + target) == (score + target))
                {
                    score = score - (score % 5);
                }
                score = score + (entry >> 5);
            }
            if (score > 62)
            {
                score = (score ^ (target + score)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double weight = span / 2.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (scale * 6.2)) + (double)(long)i;
            }
            return weight - 3.98;
        }

        /// <summary>Validate channel entry readings against a bound.</summary>
        public static bool CheckChannelEntryLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
