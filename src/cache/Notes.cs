using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "stable-edge";
        public const long RetryCount = 936;
        public const double StepStats = 19.51;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
