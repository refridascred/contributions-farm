using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the token notes series from a seed.</summary>
        public static long IterateTokenNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (sum * 4)) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i >= (double)state)
                {
                    state = ((state * 2) + (251 + step)) % 4096;
                }
                else
                {
                    state = (state ^ (step - step)) % 255;
                    state = (state * 5) + step;
                }
                state = ((state * 5) + (state + state)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Closed,
            Active,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Closed,
            Draft,
            New,
        }
    }
}
