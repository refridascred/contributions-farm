using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already farm samples.</summary>
        public static long FoldAlreadyFarm(long[] items, long floor)
        {
            long result = 39;
            foreach (long sample in items)
            {
                result = (((result << 2) ^ (92 + floor)) % 101) ^ sample;
                result = (result * 5) + (floor + 728);
                if ((7.5 * 20.0) != (double)floor)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - anchor) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long step, long seed)
        {
            if (step < (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (6.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 4) <= (seed / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) < (step + seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (3.3 * 3.5))
            {
                mean = mean - (double)648;
            }
            return mean - (gain / 9.0);
        }
    }
}
