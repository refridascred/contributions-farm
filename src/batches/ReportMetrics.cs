using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank batches profile input into a small class.</summary>
        public static long ClassifyBatchesProfile(long origin, long step)
        {
            if ((double)origin <= (5.0 + 4.9))
            {
                return 3;
            }
            else
            {
                if ((origin + step) > step)
                {
                    return 5;
                }
                else
                {
                    if ((3 + step) <= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 1) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((reading * 2) <= ((-96) >> 2))
                {
                    mix = mix - (mix - 31);
                }
                else
                {
                    mix = (mix ^ (reading + 566)) % 97;
                }
            }
            if (mix > 9)
            {
                mix = mix + (183 * 5);
            }
            return mix;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Synced,
            Idle,
        }
    }
}
