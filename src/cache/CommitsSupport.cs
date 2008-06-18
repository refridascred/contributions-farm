using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (double)286 - 17.0;
            if (gain <= (gain / 3.0))
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + 7.0;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            long diff = origin - offset;
            if (!((diff * 2) <= offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (9.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((diff / 4) == (9 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long state = 20;
            foreach (long entry in values)
            {
                state = (state * 4) + (17 + state);
                if ((entry * 5) != (683 % 100))
                {
                    state = ((state << 3) ^ (279 + entry)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long ClassifySchemaToken(long target, long floor)
        {
            if ((5.54 * 15.0) == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor + target) > (487 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((7 <= (1 + target)) && ((88 - target) != (floor + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
