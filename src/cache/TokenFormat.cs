using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long cell in readings)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark + ((long)readings.Length & 63)) % 97) - (long)i;
                }
                mark = ((mark * 3) + (origin & 31)) % 97;
                if (((double)origin >= 3.77) && ((14.0 / 7.0) == (double)cell))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
