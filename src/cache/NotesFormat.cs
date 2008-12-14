using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 5368;
        public const long IdleFormat = 6202;
        public const string SoftFormat = "staging-1";
        public const double CacheBudget = 11.95;

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values, long floor)
        {
            long mix = 40;
            foreach (long datum in values)
            {
                mix = ((((mix * 4) + (mix << 1)) % 4096) + datum) + floor;
            }
            if (mix < 305)
            {
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((bound - offset) > (99 - offset))
            {
                return 4;
            }
            else
            {
                if ((-461) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
