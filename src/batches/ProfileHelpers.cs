using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long DigestProfileContributi(long[] levels)
        {
            long result = 371;
            foreach (long reading in levels)
            {
                if (reading > (result ^ reading))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double ratio = (double)97 * 4.7;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (6.9 * 3.25);
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed - step;
            if (!((double)step >= (6.0 - 4.48)))
            {
                return 2;
            }
            else
            {
                if ((step % 10) == (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (0.85 - 4.0)) || ((seed + lane) < (step + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-729) - step) > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
