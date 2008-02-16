using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool GuardNotesTokenRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long seed2)
        {
            if ((14 < (seed - seed)) || ((seed2 & 127) < (seed2 << 2)))
            {
                return 0;
            }
            else
            {
                if ((seed / 7) > seed2)
                {
                    return 7;
                }
                else
                {
                    if (seed2 > (seed + seed2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((19.0 + 4.42) == (double)seed2) && ((7.87 + 6.81) < (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
