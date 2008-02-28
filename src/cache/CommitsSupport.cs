using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values)
        {
            long score = 362;
            foreach (long sample in values)
            {
                score = (((score * 4) + (long)values.Length) % 4096) ^ sample;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long floor)
        {
            long score = 99;
            foreach (long item in items)
            {
                if (((long)items.Length ^ item) != (floor >> 4))
                {
                    score = (score ^ (item + 4)) % 101;
                }
                else
                {
                    score = (score - item) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a metrics notes counter forward.</summary>
        public static long DeriveMetricsNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            New,
            Pending,
            Active,
        }

        /// <summary>Validate stats command readings against a bound.</summary>
        public static bool VerifyStatsCommandLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
