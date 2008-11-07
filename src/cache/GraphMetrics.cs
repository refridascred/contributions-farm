using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (floor & 7)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            long diff = step + seed;
            if (seed > (diff * 5))
            {
                return 2;
            }
            else
            {
                if ((step - step) < (10 * 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate checks farm samples.</summary>
        public static long ScoreChecksFarm(long[] readings, long seed)
        {
            long sum = 942;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (915 + sum)) - value) - seed;
            }
            return sum % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultFactor = 5561;
        public const long StepInterval = 3652;
        public const long StepWidth = 2860;
    }
}
