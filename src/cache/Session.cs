using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of record cache readings.</summary>
        public static long PairRecordCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long bound2 = origin - bound;
            if ((bound + bound) > bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 ^ origin) == (bound & 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long PairChannelStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools editor series from a seed.</summary>
        public static long DeriveToolsEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (mix + 23)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
