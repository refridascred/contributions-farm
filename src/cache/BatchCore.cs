using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Ready,
            Draft,
            Failed,
            New,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((8.7 > (4.5 * 1.97)) && ((0.2 - 18.0) >= (double)seen))
                {
                    seen = ((seen + 2) - reading) - step;
                }
            }
            return seen;
        }
    }
}
