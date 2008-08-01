using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long target)
        {
            long anchor = 540;
            foreach (long datum in series)
            {
                if ((datum & 63) <= (target + 374))
                {
                    anchor = ((anchor << 3) ^ ((-243) + datum)) % 97;
                }
                if ((anchor % 64) == (2 / 8))
                {
                    break;
                }
            }
            if (anchor > (-39))
            {
                anchor = (anchor << 3) ^ target;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count <= (count + sample)) || (target > (sample / 2))) && (((6 % 64) >= count) || ((target >> 3) != (target + 85))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
