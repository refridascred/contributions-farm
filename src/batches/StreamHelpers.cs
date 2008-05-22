using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch route readings.</summary>
        public static long CombineBatchRoute(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if ((score + score) <= (reading + reading))
                {
                    score = ((score << 3) ^ reading) % 255;
                }
                else
                {
                    score = (score - (score - reading)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long FoldCommitsCounter(long[] items, long bound)
        {
            long state = 6;
            foreach (long entry in items)
            {
                if ((bound >= (entry - state)) || (57 <= (state & 15)))
                {
                    state = (state << 3) ^ (state ^ 7);
                }
            }
            if (state < (-55))
            {
                state = (state ^ (state + state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinBudget = 5574;
        public const long DefaultRatio = 4349;
        public const string LimitStream = "legacy-v2";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)hits < 20.0) && ((double)(long)samples.Length >= (double)hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
