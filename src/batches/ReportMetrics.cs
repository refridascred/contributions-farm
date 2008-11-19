using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (result < (result - 19))
                {
                    result = ((result << 2) ^ (step / 7)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples)
        {
            long anchor = 79;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((6.0 - 3.2) >= (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
