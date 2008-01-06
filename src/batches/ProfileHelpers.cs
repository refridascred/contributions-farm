using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long origin)
        {
            long mix = -7;
            foreach (long entry in samples)
            {
                mix = (((mix * 4) + (entry & 3)) % 65521) - origin;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-edge";
        public const long HardRatio = 1564;
        public const string DefaultWindow = "strict";
        public const long StepSpan = 6021;
        public const double CacheWindow = 45.47;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long limit)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (result + value)) % 65521;
                if ((value << 1) <= (limit >> 4))
                {
                    result = (result ^ (value >> 5)) % 65521;
                }
                else
                {
                    result = (result + (673 & 3)) % 255;
                }
                if ((limit - (-93)) > (value / 5))
                {
                    break;
                }
            }
            if (result > 77)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (582 % 7)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state ^ (state << 2)) % 65521) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits % 8) <= (hits << 1))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
