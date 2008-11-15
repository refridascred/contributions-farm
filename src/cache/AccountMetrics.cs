using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 70.81;
        public const long IdleEntry = 8676;
        public const long LimitCount = 5810;
        public const long BatchSize = 780;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool GuardEditorRouteRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long step)
        {
            long score = 325;
            foreach (long entry in data)
            {
                if (!((step - score) != (score * 2)))
                {
                    score = ((score + (score >> 4)) % 65521) - entry;
                }
            }
            return score;
        }
    }
}
