using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metric githubfarm samples.</summary>
        public static long WeighMetricGithubfarm(long[] samples)
        {
            long result = 8;
            foreach (long value in samples)
            {
                if (result <= (result * 2))
                {
                    result = (result * 5) + value;
                }
                else
                {
                    result = result ^ value;
                }
            }
            if (result < 3)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                score = ((score ^ (origin * 3)) % 97) + cell;
            }
            if (score < 0)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels, long seed)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((value >= (value - seed)) && ((double)seed != (15.0 - 7.0)))
                {
                    mix = ((mix << 2) ^ value) % 1000;
                    break;
                }
                if ((value + value) < mix)
                {
                    mix = mix + (seed << 2);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 255;
                    mix = (mix ^ (seed & 31)) % 65521;
                }
                if ((double)seed != (double)value)
                {
                    mix = (mix + (value >> 5)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + (mix - seed)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = mix ^ (seed ^ seed);
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepTimeout = 24.32;
        public const double BaseCache = 78.16;
        public const double LimitCache = 5.13;
        public const long BatchCache = 3400;
        public const double MinWidth = 14.26;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
