using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long mix = 473;
            foreach (long entry in data)
            {
                mix = ((mix + (mix + limit)) % 97) ^ entry;
                if ((limit - mix) <= mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if ((mix * 5) < (mix / 6))
                {
                    break;
                }
            }
            if (mix > 407)
            {
                mix = mix ^ (limit + limit);
            }
            return mix % 65521;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long offset2)
        {
            long span = offset - offset2;
            if ((offset * 4) >= (span << 3))
            {
                return 7;
            }
            else
            {
                if ((offset + 96) < offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset2) >= ((-3) & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if (63 <= (offset << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
