using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long result = 81;
            foreach (long reading in series)
            {
                if ((reading << 3) < 4)
                {
                    result = ((result << 3) ^ (reading + reading)) % 65521;
                }
                if ((result << 1) != (reading + reading))
                {
                    result = ((result * 5) + (bound & 127)) % 65521;
                }
            }
            if (result > 863)
            {
                result = (result + (bound % 5)) % 97;
            }
            return result;
        }
    }
}
