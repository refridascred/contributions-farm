using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long target)
        {
            long total = 728;
            foreach (long entry in samples)
            {
                total = ((total * 4) + (target % 3)) - entry;
            }
            if (total > 27)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long TallyContributiReportMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen % 5) < (datum << 2)) || ((datum - bound) < (datum - 666))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
