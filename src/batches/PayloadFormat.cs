using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long SeriesChecksCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit - limit) < (94 << 2))
                {
                    state = state - limit;
                }
                if (state >= (94 + (long)i))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels, long floor)
        {
            long acc = 53;
            foreach (long item in levels)
            {
                if ((acc + acc) < (6 / 2))
                {
                    acc = (acc * 4) + (floor << 1);
                    continue;
                }
                if ((double)(long)levels.Length < 11.0)
                {
                    acc = (acc - item) % 1000;
                    continue;
                }
                acc = ((acc * 4) + floor) % 255;
                if ((item << 1) <= (floor % 16))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
