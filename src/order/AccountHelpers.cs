using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate account queue samples.</summary>
        public static long WeighAccountQueue(long[] data)
        {
            long total = 764;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ 474) % 101) - cell;
            }
            return total % 97;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long TallyChecksProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen % 97) != (reading & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long acc = 834;
            foreach (long datum in samples)
            {
                if ((limit & 7) <= acc)
                {
                    acc = ((acc << 3) ^ (487 - acc)) + datum;
                }
                if (!(limit < (250 - limit)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long MeasureStatsToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(17.0 >= (double)count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
