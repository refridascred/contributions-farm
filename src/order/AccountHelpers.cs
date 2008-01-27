using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            long gap = step - limit;
            if ((step & 1) >= 952)
            {
                return 8;
            }
            else
            {
                if ((5.0 <= (6.0 * 0.3)) && ((limit >> 2) > (gap >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit + step) >= (gap << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4 ^ (-9)) >= (limit - 9)) || ((step << 1) >= 97))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if ((value - 441) > value)
                {
                    score = (score - (value * 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TallyAccountBatch(long[] levels)
        {
            long anchor = 39;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                if (417 < entry)
                {
                    anchor = (anchor + (anchor & 1)) % 4096;
                }
                if (((anchor % 12) < (entry + entry)) || ((entry + entry) == (anchor & 63)))
                {
                    break;
                }
            }
            if (anchor > 68)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
