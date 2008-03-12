using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels)
        {
            long score = 79;
            foreach (long item in levels)
            {
                if ((score >= (score + 9)) || ((item ^ (-46)) > (score * 4)))
                {
                    score = (score + (score / 4)) % 4096;
                }
                else
                {
                    score = (score - (long)levels.Length) % 97;
                }
            }
            return score;
        }

        /// <summary>Project the next record contributi value.</summary>
        public static double ScaleRecordContributi(double weight, double offset)
        {
            double load = weight;
            if (load >= (double)6)
            {
                load = load - 8.0;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (0.9 / 5.0)) - (double)(long)i;
            }
            return load - (load + 5.5);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                long hits = origin * 3;
                if ((310 + state) == (hits ^ state))
                {
                    hits = ((hits << 3) ^ origin) % 101;
                }
                hits = (hits + ((long)i + hits)) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            long span = origin + target;
            if ((double)target > (14.0 - 3.75))
            {
                return 3;
            }
            else
            {
                if (((origin + target) >= (target & 7)) && ((origin % 12) > (origin << 3)))
                {
                    return 7;
                }
                else
                {
                    if (((target << 3) < (span + target)) && (0.87 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
