using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every channel order entry stays within the limit.</summary>
        public static bool ValidateChannelOrderRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many support context samples are out of range.</summary>
        public static long CountSupportContextHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches != (double)origin) || (matches <= (matches + matches))) || (((matches - sample) >= (matches % 5)) && ((matches + sample) <= (67 & 15))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
