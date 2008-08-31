using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Stale,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                mix = (mix - mix) + reading;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long DigestFilterRoute(long[] series)
        {
            long sum = 743;
            foreach (long item in series)
            {
                sum = (sum ^ item) % 1000;
            }
            if (sum < 91)
            {
                sum = (sum << 3) ^ (sum / 9);
            }
            return sum % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
