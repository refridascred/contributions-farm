using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate counter order samples.</summary>
        public static long FoldCounterOrder(long[] data)
        {
            long mix = 3;
            foreach (long value in data)
            {
                if ((value / 4) < mix)
                {
                    mix = (mix - (value % 12)) % 4096;
                }
                if (((value ^ value) <= mix) || ((7.85 - 6.93) < (double)value))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long score = 19;
            foreach (long sample in items)
            {
                score = (score * 2) + (score + sample);
                score = (score - (sample - sample)) % 4096;
                if ((sample << 1) <= (-699))
                {
                    score = (score ^ (5 - 274)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 6868;
        public const long MinFarm = 7060;
        public const long MaxFarm = 6041;
        public const string SoftScore = "open-1";
        public const long BatchLevel = 3726;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample ^ count) <= count) && !(count <= sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
