using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score + score) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long target)
        {
            long state = 775;
            foreach (long datum in readings)
            {
                if (56 > state)
                {
                    state = state - (state / 4);
                }
                if ((target ^ datum) <= datum)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
