using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long state = 97;
            foreach (long datum in readings)
            {
                state = (((state * 5) + (state + state)) % 101) + datum;
            }
            if (state > 68)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((61 - bound) >= state) && ((7.7 / 4.0) != (double)state))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((bound + (long)i) != ((long)i + bound)) && ((state / 2) <= bound))
                {
                    state = (state - (0 ^ state)) % 1000;
                    state = state ^ (bound + state);
                }
                state = ((state << 3) ^ (bound << 3)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = -65;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total ^ (sample * 2)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total ^ 204) % 4096) + (long)i2;
                }
                total = (total * 5) + (total - total);
            }
            if (total < (-8))
            {
                total = (total + (total >> 1)) % 255;
            }
            return total;
        }
    }
}
