using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many commits schema samples are out of range.</summary>
        public static long AuditCommitsSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((double)datum < 7.3) && ((matches << 1) <= (82 - matches))) && ((datum ^ datum) == (datum - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Locked,
            Paused,
            Closed,
        }
    }
}
