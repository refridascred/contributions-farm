using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= (step >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter route value from a seed.</summary>
        public static long DeriveCounterRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ (score / 2)) + (long)i2;
                    score = (score * 5) + (score * 4);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every tools graph entry stays within the limit.</summary>
        public static bool VerifyToolsGraphBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
