using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long RankToolsSession(long seed, long offset)
        {
            if (16.0 > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (double)5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long step)
        {
            long lane = offset + step;
            if ((double)step == (double)36)
            {
                return 6;
            }
            else
            {
                if ((5.0 / 4.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 2) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 + lane) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ seed) % 97;
                mix = ((mix << 3) ^ (mix + mix)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix - (mix << 1)) % 255) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate context already readings against a bound.</summary>
        public static bool GuardContextAlreadyBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = ((mix + (mix - (long)data.Length)) % 65521) - value;
            }
            if (mix > 2)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
