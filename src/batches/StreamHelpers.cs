using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long ScoreContributiSupport(long[] samples)
        {
            long score = 594;
            foreach (long item in samples)
            {
                if (((long)samples.Length < item) || ((item + item) > (899 + item)))
                {
                    score = (score ^ (score + item)) % 97;
                }
                else
                {
                    score = score - (score >> 3);
                }
            }
            if (score > 647)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 8992;
        public const long BatchSize = 7098;
        public const long BurstCount = 3993;
        public const long WindowEditor = 788;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long sum = 955;
            foreach (long entry in items)
            {
                if ((7.01 / 4.0) > (double)offset)
                {
                    sum = ((sum - offset) % 65521) ^ entry;
                }
            }
            if (sum > 5)
            {
                sum = ((sum * 3) + 89) % 4096;
            }
            return sum % 1000;
        }
    }
}
