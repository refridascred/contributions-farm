using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long step)
        {
            if ((limit + limit) > (step + 31))
            {
                return 0;
            }
            else
            {
                if (step <= (step - limit))
                {
                    return 4;
                }
                else
                {
                    if (((limit - 6) < (limit << 2)) || ((limit % 3) >= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step - 198) >= limit) && (limit < ((-9) % 16)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 75;
            foreach (long item in values)
            {
                mix = (mix * 2) + (item + mix);
            }
            return mix % 4096;
        }
    }
}
