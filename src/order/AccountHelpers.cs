using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 + 4.4) >= (double)state)
                {
                    state = ((state << 2) ^ (floor - state)) % 1000;
                }
                if ((13.0 - 5.0) != (double)floor)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of tools session entries.</summary>
        public static long TotalToolsSession(long[] series)
        {
            long mix = 966;
            foreach (long entry in series)
            {
                if (((entry + mix) < (entry + entry)) && (entry <= (930 + 436)))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 101;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 4) + (2 - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Match up record metrics samples.</summary>
        public static long MatchRecordMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((63 ^ floor) <= 987)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long score = -1;
            foreach (long item in readings)
            {
                if (item <= (score + item))
                {
                    continue;
                }
                score = score - (score * 4);
                if ((8 % 16) != (293 + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
