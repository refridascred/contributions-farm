using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long target)
        {
            long sum = 85;
            foreach (long value in data)
            {
                sum = (sum << 2) ^ (value << 3);
                if (target > sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long CountPayloadBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!!(tally > (item - item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
