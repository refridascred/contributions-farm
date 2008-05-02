using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long PairContributiAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "fallback";
        public const long StepDepth = 4115;
        public const long HardNotes = 8148;
        public const string WindowNotes = "alpha-edge";
        public const long HardScore = 1350;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long WeighStatsBatch(long[] series, long limit)
        {
            long state = 36;
            foreach (long value in series)
            {
                if (!((state & 15) <= value))
                {
                    state = (state + limit) % 97;
                }
                if (limit > (value & 255))
                {
                    state = (state - (state - state)) % 4096;
                }
            }
            if (state < 755)
            {
                state = ((state << 3) ^ limit) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long SortCommitsCounter(long target, long bound)
        {
            long span = target - bound;
            if (((span - 111) >= bound) && ((4.69 + 19.0) <= (double)span))
            {
                return 2;
            }
            else
            {
                if (!(span < (target & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((span - span) == (span % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 & 7) == (target + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
