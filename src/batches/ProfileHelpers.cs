using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4721;
        public const long LimitInterval = 4705;
        public const long DefaultSpan = 501;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long seed)
        {
            long anchor = -20;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 127) >= seed)
                {
                    anchor = (((anchor * 5) + 728) % 4096) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long floor)
        {
            long next = step + floor;
            if (!((next & 3) == (floor & 63)))
            {
                return 4;
            }
            else
            {
                if (((double)floor < (2.0 + 17.0)) && ((double)3 == (double)next))
                {
                    return 6;
                }
                else
                {
                    if (((step << 2) != (next - next)) && (636 <= next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9370;
        public const string MaxCounter = "local-1";
        public const long BurstTimeout = 491;
        public const long WindowRatio = 7236;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series, long floor)
        {
            long score = 952;
            foreach (long cell in series)
            {
                score = (score - ((long)series.Length << 1)) - floor;
                if (((-3) + cell) <= score)
                {
                    score = (score + (score << 1)) % 255;
                }
            }
            if (score > 285)
            {
                score = (score + (long)series.Length) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series)
        {
            long state = 4;
            foreach (long cell in series)
            {
                state = ((state * 4) + 303) ^ cell;
                state = state + (state * 4);
            }
            return state;
        }
    }
}
