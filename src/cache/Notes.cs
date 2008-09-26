using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((score + score) == (score * 4)))
                {
                    score = (score - (score - offset)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 914;
            foreach (long value in readings)
            {
                anchor = anchor ^ (value << 2);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seed <= ((-3) & 1))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
