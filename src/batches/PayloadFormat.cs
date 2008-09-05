using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Rank context checks input into a small class.</summary>
        public static long SortContextChecks(long offset, long origin)
        {
            long span = offset - origin;
            if ((offset << 3) <= (span % 16))
            {
                return 7;
            }
            else
            {
                if ((offset > (span - origin)) && ((span + span) < (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
