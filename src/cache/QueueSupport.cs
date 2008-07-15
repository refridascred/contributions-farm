using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Paused,
            New,
            Stale,
            Active,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long bound)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if (bound > mix)
                {
                    mix = ((mix << 2) ^ (70 + 185)) % 65521;
                }
                if ((bound > (value * 3)) && (value > ((long)samples.Length + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
