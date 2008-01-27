using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count stats record pairs that satisfy a relation.</summary>
        public static long OverlapStatsRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (!((floor + floor2) > (floor - next)))
            {
                return 0;
            }
            else
            {
                if ((double)next == (1.48 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((11.0 * 8.6) <= (double)seen)
                {
                    seen = ((seen + 3) - entry) - target;
                }
            }
            return seen;
        }
    }
}
