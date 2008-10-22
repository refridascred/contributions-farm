using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long floor)
        {
            long mix = 417;
            foreach (long entry in values)
            {
                if (((mix >> 5) == (mix - mix)) || ((mix % 7) == (long)values.Length))
                {
                    mix = (mix ^ (entry * 2)) - floor;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long RankChecksGraph(long offset, long seed)
        {
            if ((70 < seed) || ((offset * 3) >= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if (((double)seed >= 12.0) || (seed <= (seed / 5)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < ((-4) * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
